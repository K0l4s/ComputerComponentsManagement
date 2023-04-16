-- Script Reset Database 
USE master;
GO
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'HEQUANTRICOSODULIEU')
BEGIN
    ALTER DATABASE HEQUANTRICOSODULIEU SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE HEQUANTRICOSODULIEU;
END
CREATE DATABASE HEQUANTRICOSODULIEU;
GO
USE HEQUANTRICOSODULIEU;
GO

-- CREATE DATATABLE
CREATE TABLE AUTHORIZATION_USER(
				authorID INT PRIMARY KEY NOT NULL,
				authorName VARCHAR(255) NOT NULL);
				GO
CREATE TABLE BRAND(
				 brandID VARCHAR(10) PRIMARY KEY NOT NULL,
				 brandName VARCHAR(255) NOT NULL);
				 GO
CREATE TABLE PRODUCT_TYPE(
				 typeID VARCHAR(10) PRIMARY KEY NOT NULL,
				 typeName VARCHAR(255) NOT NULL);
				 GO
CREATE TABLE PRODUCT(
				productID VARCHAR(10) PRIMARY KEY NOT NULL,
				productName VARCHAR(255) NOT NULL,
				productImageURL VARBINARY(max),
				quantity INT NOT NULL,
				CHECK(quantity >= 0));
				GO
CREATE TABLE PRODUCT_DETAIL(
				productID VARCHAR(10) NOT NULL PRIMARY KEY REFERENCES PRODUCT(productID),
				typeID VARCHAR(10) NOT NULL REFERENCES PRODUCT_TYPE(typeID),
				brandID VARCHAR(10) NOT NULL REFERENCES BRAND(brandID),
				importPrice INT NOT NULL,
				sellPrice INT NOT NULL,
				Check(importPrice >=0),
				Check(sellPrice >=0),
				descript VARCHAR(1000));
				GO
CREATE TABLE EMPLOYEE(
				employeeID INT PRIMARY KEY NOT NULL,
				fullName VARCHAR(50) NOT NULL,
				sex VARCHAR(6) NOT NULL,
				formatName VARCHAR(10) NOT NULL,
				wage FLOAT NOT NULL,
				employeeImage VARCHAR(255),
				phoneNumber VARCHAR(10) UNIQUE NOT NULL,
				Em_address VARCHAR(255),
				citizenID VARCHAR(12) UNIQUE NOT NULL,
				commissionRate FLOAT  NOT NULL,
				dateOfBirth DATE NOT NULL,
				age INT,
				statusJob VARCHAR(255), 
				authorID INT NOT NULL REFERENCES AUTHORIZATION_USER(authorID),
				CHECK(len(citizenID) =12), --CCCD phải có đúng 12 chữ số
				CHECK(len(phoneNumber) = 10)); --Số điện thoại phải có đúng 10 chữ số
				GO
CREATE TABLE COMMISSION_DETAIL(
				comAnaID INT NOT NULL PRIMARY KEY,
				brandID VARCHAR(10) NOT NULL REFERENCES BRAND(brandID),
				minCommission INT)
				GO
CREATE TABLE ACCOUNT(
				employeeID INT PRIMARY KEY NOT NULL REFERENCES EMPLOYEE(employeeID),
				emp_password VARCHAR(255) NOT NULL,
				CHECK (len(emp_password)>=6)); --PASSWORD phải có ít nhất 06 ký tự
				GO
CREATE TABLE WORK_TIME(
				employeeID INT NOT NULL REFERENCES EMPLOYEE(employeeID),
				checkIn DATETIME NOT NULL,
				checkOut DATETIME,
				PRIMARY KEY (employeeID, checkIn));
				GO
CREATE TABLE CUSTOMER(
				phoneNumber VARCHAR(10) NOT NULL PRIMARY KEY,
				fullName VARCHAR(50) NOT NULL,
				cus_address VARCHAR(255));
				GO
CREATE TABLE VOUCHER_STATUS(
				voucherStatusID INT PRIMARY KEY,
				voucherStatusName VARCHAR(255));
				GO
CREATE TABLE VOUCHER(
				voucherID VARCHAR(15) PRIMARY KEY NOT NULL,
				voucherName VARCHAR(255) NOT NULL,
				percentReduction FLOAT NOT NULL,
				voucherStatusID INT REFERENCES VOUCHER_STATUS(voucherStatusID),
				expiryDate DATETIME,
				limitNumber INT,
				numberUsed INT);
				GO
CREATE TABLE BILL(
				billID VARCHAR(20) PRIMARY KEY NOT NULL,
				employeeID INT REFERENCES EMPLOYEE(employeeID) NOT NULL,
				phoneNumber VARCHAR(10) REFERENCES CUSTOMER(phoneNumber),
				billExportTime DATETIME)
				GO
CREATE TABLE VOUCHER_APPLY(
				billID VARCHAR(20) NOT NULL REFERENCES BILL(billID),
				voucherID VARCHAR(15) PRIMARY KEY REFERENCES VOUCHER(voucherID));
				GO
CREATE TABLE BILL_DETAIL(
				billID VARCHAR(20) NOT NULL REFERENCES BILL(billID),
				productID VARCHAR(10) NOT NULL REFERENCES PRODUCT(productID),
				number INT NOT NULL,
				PRIMARY KEY(billID, productID));
				GO
CREATE TABLE IMPORT(
				importID VARCHAR(20) PRIMARY KEY NOT NULL,
				employeeID INT REFERENCES EMPLOYEE(employeeID) NOT NULL,
				importDate DATETIME NOT NULL);
				GO
CREATE TABLE IMPORT_DETAIL(
				importID VARCHAR(20) NOT NULL REFERENCES IMPORT(importID),
				productID VARCHAR(10) NOT NULL REFERENCES PRODUCT(productID),
				PRIMARY KEY (importID, productID),
				numberOfImport INT NOT NULL,
				descript VARCHAR(1000));
				GO
CREATE TABLE WARRANTY_STATUS(
				warr_StatusID INT NOT NULL PRIMARY KEY,
				statusName VARCHAR(100) NOT NULL);
				GO
CREATE TABLE WARRANTY_CARD(
				productID VARCHAR(10) NOT NULL PRIMARY KEY REFERENCES PRODUCT(productID),
				warr_StatusID INT NOT NULL REFERENCES WARRANTY_STATUS(warr_StatusID),
				descript VARCHAR(1000));
				GO

--TRIGGER FINAL

CREATE  TRIGGER AUTO_CREATE_ACCOUNT ON EMPLOYEE
FOR INSERT
AS
BEGIN
  DECLARE @employeeID INT, @employeeName VARCHAR(255), @password VARCHAR(255)
  SELECT @employeeID = employeeID FROM inserted
  SET @password = SUBSTRING(CAST(NEWID() AS VARCHAR(36)), 1, 6)
  INSERT INTO Account (employeeID, emp_Password)
  VALUES (@employeeID, @password)
  Print('Tao tai khoan nhan vien thanh cong!');
END;
GO

CREATE TRIGGER AUTO_DELETE_ACCOUNT
ON Employee
AFTER UPDATE
AS
BEGIN
    IF UPDATE(statusJob) AND EXISTS(SELECT 1 FROM inserted WHERE statusJob = 'Non-Active') -- kiểm tra xem cột statusJob có được cập nhật hay không
    BEGIN
        DELETE FROM ACCOUNT WHERE employeeID  = (SELECT employeeID FROM inserted)
    END
END;
GO

CREATE TRIGGER AUTO_CREATE_ACCOUNT_CONTINUE_WORK
ON EMPLOYEE
AFTER UPDATE
AS
BEGIN
IF ((SELECT statusJob FROM inserted) = 'Active')
BEGIN
	DECLARE @employeeID INT, @employeeName VARCHAR(255), @password VARCHAR(255)
	SELECT @employeeID = employeeID FROM inserted
		-- Kiểm tra xem đã có bản ghi nào trong bảng ACCOUNT có cùng employeeID chưa
		IF NOT EXISTS (SELECT * FROM ACCOUNT WHERE employeeID = @employeeID)
		BEGIN
			SET @password = SUBSTRING(CAST(NEWID() AS VARCHAR(36)), 1, 6)
			INSERT INTO Account (employeeID, emp_Password)
			VALUES (@employeeID, @password) 
		END
		ELSE
		BEGIN
			-- Nếu đã có bản ghi thì cập nhật lại mật khẩu
			SET @password = SUBSTRING(CAST(NEWID() AS VARCHAR(36)), 1, 6)
			UPDATE ACCOUNT SET emp_Password = @password WHERE employeeID = @employeeID
		END
	END
END;
GO

CREATE TRIGGER CHECK_PRICE
ON PRODUCT_DETAIL
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @IP INT, @SP INT
	SELECT @IP = importPrice , @SP = sellPrice FROM inserted
	IF(@IP > @SP)
		BEGIN
			Print('Gia ban nhap vao lon hon gia nhap! Xin vui long kiem tra lai!');
			ROLLBACK TRANSACTION
		END
END;
go

CREATE TRIGGER AUTO_CHECK_VOUCHER
ON VOUCHER_APPLY
AFTER INSERT, UPDATE
AS
BEGIN
		
	DECLARE @voucherID VARCHAR(15),@limitNumber INT, @numberUsed INT, @expiryDate DateTime,@status VARCHAR(15)
	SELECT @voucherID = voucherID FROM inserted
	SELECT @expiryDate = expiryDate, @status = voucherStatusID, @limitNumber = limitNumber, @numberUsed = numberUsed FROM inserted i INNER JOIN VOUCHER v ON i.voucherID = v.voucherID
	IF((@expiryDate < GETDATE()))
	BEGIN
		UPDATE VOUCHER
		SET voucherStatusID = 2
		WHERE voucherID = @voucherID
		SELECT @status = 2
	END
	IF((@limitNumber < @numberUsed + 1)) 
	BEGIN
		UPDATE VOUCHER
		SET voucherStatusID = 2
		WHERE voucherID = @voucherID
		SELECT @status = 2
	END

	IF(@status = 2)
	BEGIN
			Print('Voucher da het han! Xin vui long thu lai sau!')
			ROLLBACK TRANSACTION
	END
	ELSE IF(@status = 1)
		BEGIN
			Print('Voucher du dieu kien su dung!')
			Print('Da ap dung Voucher thanh cong!')
		END
END;
GO

CREATE TRIGGER TRG_AUTO_SET_STATUSJOB
ON EMPLOYEE
AFTER INSERT
AS
BEGIN
	DECLARE @active VARCHAR(255) = 'Active';
	UPDATE EMPLOYEE 
	SET statusJob = @active
	WHERE employeeID IN (SELECT employeeID FROM inserted) AND statusJob IS NULL;
END
GO

CREATE TRIGGER CHECK_MANAGER
ON IMPORT
FOR INSERT
AS
BEGIN
	IF((SELECT e.authorID -- Chọn phân quyền của employee
	FROM inserted i INNER JOIN EMPLOYEE e ON i.employeeID = e.employeeID) --Kết bảng vừa nhập và bảng Employee
	!= 1) --Vì cấp bậc quản lý có cấp author ID là 1
	BEGIN
		PRINT('Cap bac nhan vien khong du de thuc hien chuc nang, xin thu lai sau!')
		ROLLBACK;
	END
	ELSE
	BEGIN
		PRINT('Nhap hang thanh cong!')
	END
END;
GO

CREATE TRIGGER CHECK_CITIZENID
ON EMPLOYEE
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @maTinh VARCHAR(3), @maGioiTinh VARCHAR(1), @maNamSinh VARCHAR(2)
	SELECT  @maTinh = SUBSTRING(citizenID, 1, 3),
       @maGioiTinh = SUBSTRING(citizenID, 4, 1),
	   @maNamSinh = SUBSTRING(citizenID, 5,6)
	FROM inserted
	IF ( ( Convert(INT ,@maTinh ) >= 1 ) AND ( CONVERT(INT, @maTinh) <=96) ) -- Kiểm tra mã tỉnh có đúng định dạng chưa
	BEGIN
		-- Kiểm tra giới tính trên căn cước với hệ thống
		IF ( (Convert(INT ,@maGioiTinh) = 0) OR (Convert(INT ,@maGioiTinh) = 2) OR (Convert(INT ,@maGioiTinh) = 4) OR (Convert(INT ,@maGioiTinh) = 6) OR (Convert(INT ,@maGioiTinh) = 8) )
		BEGIN
			IF( (SELECT sex FROM inserted) = 'Female')
			BEGIN
				PRINT('Gioi Tinh Khong Khop Voi Can Cuoc Cong Dan. Xin Vui Long Kiem Tra Lai!')
				ROLLBACK TRANSACTION
			END
		END
		ELSE
		BEGIN
			IF( (SELECT sex FROM inserted) = 'Male' )
			BEGIN
				PRINT('Gioi Tinh Khong Khop Voi Can Cuoc Cong Dan. Xin Vui Long Kiem Tra Lai!')
				ROLLBACK TRANSACTION
			END
		END

		DECLARE @yearOBirth VARCHAR(2), @currentYear INT
		SELECT @currentYear = YEAR(GETDATE()) - 2000
		IF ( (SELECT YEAR(dateOfBirth) FROM inserted) > 1999 )
		BEGIN
			IF(CONVERT(INT,@maNamSinh) > @currentYear)
			BEGIN
				PRINT('So Can Cuoc Khong Khop Voi Thoi Gian Thuc Tai! Vui Long Kiem Tra Lai!')
				ROLLBACK TRANSACTION
			END
		END
		SELECT @yearOBirth = RIGHT(CONVERT(VARCHAR(4), dateOfBirth), 2)FROM inserted
		IF(@maNamSinh != @yearOBirth) --Kiểm tra năm sinh trên CCCD với hệ thống
		BEGIN
			PRINT('Ma Nam Sinh Khong Khop Voi Thong Tin Da Nhap. Xin Vui Long Kiem Tra Lai!')
			ROLLBACK TRANSACTION
		END
	END
	ELSE
	BEGIN
		--PRINT('fgsdg')
		 PRINT(CONVERT(VARCHAR,@maTinh) + ' ' + CONVERT(VARCHAR,@maGioiTinh) + ' '+ CONVERT(VARCHAR,@maNamSinh) )
		 --PRINT('Can Cuoc Cong Dan Khong Hop Le! Tao tai khoan that bai!')
		ROLLBACK TRANSACTION
	END
END
go

CREATE TRIGGER BUY_PRODUCT
ON BILL_DETAIL
AFTER INSERT, UPDATE
--làm trc về sau dính nhiều thứ lắm ,
AS 
BEGIN
	DECLARE @buyQuantity INT, @oldBQuantity INT
	SELECT @buyQuantity = number
	FROM inserted 
	SET @oldBQuantity = 0
    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        SELECT @oldBQuantity = number
        FROM deleted
    END
	UPDATE PRODUCT
	SET quantity = quantity - (@buyQuantity-@oldBQuantity)
	WHERE productID = (SELECT productID FROM inserted)
END
GO

CREATE TRIGGER IMPORT_PRODUCT
ON IMPORT_DETAIL
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @iQuan INT, @oldIQ INT
	SELECT @iQuan = numberOfImport FROM inserted 
	SET @oldIQ = 0
	IF EXISTS (SELECT 1 FROM deleted)
	BEGIN
		SELECT @oldIQ = numberOfImport FROM deleted
	END
	UPDATE PRODUCT
	SET quantity = quantity + (@iQuan - @oldIQ)
	WHERE productID = (SELECT productID FROM inserted)
END
GO

-- VIEW FINAL
CREATE VIEW VIEW_VOUCHER AS
	SELECT voucherID , vc.voucherName as [Name Voucher], percentReduction as [Percent Reduction ] ,vcs.voucherStatusName as [Name of status] , expiryDate , limitNumber , numberUsed 
	FROM VOUCHER vc INNER JOIN VOUCHER_STATUS vcs
			ON vc.voucherStatusID = vcs.voucherStatusID;
	GO

CREATE VIEW VIEW_CUSTOMER AS 
	SELECT fullName as [Full Name] , phoneNumber as[Number Phone], cus_address as Address
	FROM CUSTOMER;
	GO

CREATE VIEW VIEW_EMPLOYEE
AS
SELECT 
    e.employeeID AS EmloyeeID,
    a.emp_password AS Password,
    e.fullName AS FullName,
    e.sex AS Sex,
    e.formatName AS FormatName,
    e.wage AS Wage,
    e.employeeImage AS EmployeeImage,
    e.phoneNumber AS PhoneNumber,
    e.Em_address AS Address,
    e.citizenID AS CitizenID,
    e.commissionRate AS CommissionRate,
    e.dateOfBirth AS DateOfBirth,
    e.age AS Age,
    e.statusJob AS StatusJob,
    u.authorName AS AuthorName
FROM EMPLOYEE e
INNER JOIN AUTHORIZATION_USER u ON e.authorID = u.authorID
INNER JOIN ACCOUNT a ON e.employeeID = a.employeeID
GO

CREATE VIEW COMPLETED_BILL_DETAIL AS
	SELECT billID, pd.productID, number, sellPrice*number as totalMoney
	FROM BILL_DETAIL bd INNER JOIN PRODUCT_DETAIL pd
	ON bd.productID = pd.productID;
GO
	
CREATE VIEW COMPLETED_BILL AS
	SELECT b.billID, b.employeeID, b.phoneNumber, b.billExportTime, SUM(cbd.totalMoney) as totalPay
	FROM BILL b INNER JOIN COMPLETED_BILL_DETAIL cbd
		ON b.billID = cbd.billID
	GROUP BY b.billID, b.employeeID, b.phoneNumber, b.billExportTime;
	GO

CREATE VIEW VIEW_PRODUCT AS 
	SELECT pd.productID, pd.productName, pd.productImageURL, pd.quantity
	FROM PRODUCT pd INNER JOIN PRODUCT_DETAIL pdt
	ON pd.productID = pdt.productID
	GROUP BY pd.productID, pd.productName, pd.productImageURL, pd.quantity;
	GO

CREATE VIEW VIEW_WARRENTY AS
	SELECT wr.productID, wr.warr_StatusID, wr.descript
	FROM WARRANTY_CARD wr INNER JOIN BILL_DETAIL bld
	ON wr.productID = bld.productID
	GROUP BY wr.productID, wr.warr_StatusID, wr.descript;
	GO

--Func + Proc
--FUNCTION FINAL

CREATE FUNCTION FUNC_GetMaxEmployeeId()
RETURNS INT
AS
BEGIN
    DECLARE @maxId INT
    SELECT @maxId = MAX(employeeID) FROM EMPLOYEE
    RETURN @maxId
END
GO

CREATE FUNCTION FUNC_CheckAuthorExists(@AuthorName VARCHAR(50))
RETURNS INT
AS
BEGIN
    DECLARE @AuthorId INT
    SELECT TOP 1 @AuthorId = authorID FROM AUTHORIZATION_USER WHERE authorName = @AuthorName
    IF @AuthorId IS NULL
        SELECT TOP 1 @AuthorId = authorID FROM AUTHORIZATION_USER
    RETURN @AuthorId
END
GO

CREATE FUNCTION FUNC_CHECK_EMPLOYEE_VALUE(
	@Sex nvarchar(max),
	@PhoneNumber nvarchar(max),
	@CitizenID nvarchar(max),
	@Wage float,
	@CommissionRate float
)
RETURNS nvarchar(max)
AS
BEGIN
	DECLARE @result nvarchar(max) = ''

	IF @Sex NOT IN ('Male', 'Female')
	BEGIN
		SET @result = 'Sex must be "Male" or "Female". '
	END

	IF LEN(@PhoneNumber) <> 10 OR @PhoneNumber NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
	BEGIN
		SET @result = @result + 'PhoneNumber must have 10 digits. '
	END

	IF @CitizenID IS NULL OR LEN(@CitizenID) <> 12 OR @CitizenID NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
	BEGIN
		SET @result = @result + 'CitizenID must have 12 digits. '
	END
	--ELSE IF EXISTS (SELECT 1 FROM EMPLOYEE WHERE citizenID = @CitizenID)
	--BEGIN
	--	SET @result = @result + 'CitizenID is already in use. '
	--END

	IF @Wage <= 0
	BEGIN
		SET @result = @result + 'Wage must be greater than 0. '
	END

	IF @CommissionRate < 0 OR @CommissionRate > 1
	BEGIN
		SET @result = @result + 'CommissionRate must be between 0 and 1. '
	END

	RETURN @result
END
GO

CREATE FUNCTION FUNC_TOP5_PRODUCT(@Daystart DATE, @Dayend DATE)
RETURNS TABLE
AS
RETURN
    SELECT TOP 5 pd.productID , p.productName , SUM(bd.number) AS totalSold 
    FROM BILL_DETAIL bd 
    INNER JOIN PRODUCT_DETAIL pd ON bd.productID = pd.productID 
    INNER JOIN BILL b ON bd.billID = b.billID
	INNER JOIN PRODUCT p ON p.productID = pd.productID
    WHERE b.billExportTime BETWEEN @Daystart AND @Dayend
    GROUP BY pd.productID ,p.productName
    ORDER BY totalSold DESC;
GO

CREATE FUNCTION FUNC_BOTTOM5_PRODUCT(@Daystart DATE, @Dayend DATE)
RETURNS TABLE
AS
RETURN
    SELECT TOP 5 pd.productID, pd.brandID, pd.typeID, p.productName , SUM(bd.number) AS totalSold, b.billExportTime
	FROM BILL_DETAIL bd 
	INNER JOIN PRODUCT_DETAIL pd ON bd.productID = pd.productID
	INNER JOIN BILL b ON bd.billID = b.billID
	INNER JOIN PRODUCT p ON p.productID = pd.productID
	WHERE b.billExportTime BETWEEN @Daystart AND @Dayend
	GROUP BY pd.productID, pd.brandID, pd.typeID, b.billExportTime,p.productName
	ORDER BY totalSold ASC;
GO

CREATE FUNCTION FUNC_TOTAL_REVENUE(@Daystart DATE, @Dayend DATE)
RETURNS INT
AS
BEGIN
    DECLARE @TotalValue INT
    SELECT @TotalValue = SUM(totalPay)
    FROM COMPLETED_BILL
    WHERE billExportTime BETWEEN @DayStart AND @DayEnd
    RETURN @TotalValue
END
GO

CREATE FUNCTION FUNC_TOTAL_COMPLETE_BILL(@Daystart DATE, @Dayend DATE)
RETURNS INT
AS
BEGIN
    DECLARE @TotalValue INT
    SELECT @TotalValue = COUNT(CB.billID)
    FROM COMPLETED_BILL CB
    WHERE CB.billExportTime BETWEEN @DayStart AND @DayEnd
    RETURN @TotalValue
END
GO

CREATE FUNCTION FUNC_TOTAL_COMPLETE_BILL_COMPONENT(@Daystart DATE, @Dayend DATE)
RETURNS INT
AS
BEGIN
    DECLARE @TotalValue INT
    SELECT @TotalValue = COUNT(CBL.productID)
    FROM COMPLETED_BILL CB 
	INNER JOIN COMPLETED_BILL_DETAIL CBL ON CB.billID = CBL.billID
    WHERE CB.billExportTime BETWEEN @DayStart AND @DayEnd
    RETURN @TotalValue
END
GO


-- PROCEDURE FINAL

--Kien
--CREATE PROC GetInforEmployeeByID @employeeID  INT
--AS
--	SELECT *
--	FROM VIEW_EMPLOYEE
--	WHERE employeeID = @employeeID;
--GO
--CREATE PROCEDURE Change_Password 
--	@employeeID INT, 
--	@newPassword VARCHAR(255), 
--	@oldPassword VARCHAR(255)
--AS
--BEGIN
--	DECLARE @oldPasswordData VARCHAR(255)
--	SELECT @oldPasswordData = emp_password
--	FROM ACCOUNT
--	WHERE employeeID = @employeeID
	
--	IF(@oldPassword = @oldPasswordData)
--	BEGIN
--		UPDATE ACCOUNT
--		SET emp_password = @newPassword
--		WHERE employeeID = @employeeID
--		RETURN 1
--	END
--	ELSE
--		RETURN 0
--END
--GO

--Nhat

CREATE PROCEDURE PROD_InsertEmployee
    @FullName nvarchar(max),
    @Sex nvarchar(max),
    @FormatName nvarchar(max),
    @Wage FLOAT ,
    @EmployeeImage nvarchar(max),
    @PhoneNumber nvarchar(max),
    @Address nvarchar(max),
    @CitizenID nvarchar(max),
    @CommissionRate nvarchar(max),
    @DateOfBirth date,
    @Age int,
    @AuthorName nvarchar(max)
AS
BEGIN
	DECLARE @maxID INT = dbo.FUNC_GetMaxEmployeeId() + 1
	DECLARE @AuthorID INT =  dbo.FUNC_CheckAuthorExists(@AuthorName)
	DECLARE @errorMsg nvarchar(max) = dbo.FUNC_CHECK_EMPLOYEE_VALUE(@Sex, @PhoneNumber, @CitizenID, @Wage , @CommissionRate)
	IF @errorMsg <> ''
	BEGIN
		RAISERROR(@errorMsg, 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	
	
    INSERT INTO Employee(employeeID, FullName, Sex, FormatName, Wage, EmployeeImage, PhoneNumber, Em_address, CitizenID, CommissionRate, DateOfBirth, Age, AuthorID)
    VALUES ( @maxID , @FullName, @Sex, @FormatName, @Wage, @EmployeeImage, @PhoneNumber, @Address, @CitizenID, @CommissionRate, @DateOfBirth, @Age, @AuthorID)
END
GO

CREATE PROCEDURE PROD_UpdateEmployee
	@employeeID INT,
    @FullName nvarchar(max),
    @Sex nvarchar(max),
    @FormatName nvarchar(max),
    @Wage FLOAT ,
    @EmployeeImage nvarchar(max),
    @PhoneNumber nvarchar(max),
    @Address nvarchar(max),
    @CitizenID nvarchar(max),
    @CommissionRate nvarchar(max),
    @DateOfBirth date,
    @Age int,
    @AuthorName nvarchar(max)
AS
BEGIN
	BEGIN TRANSACTION 
	DECLARE @AuthorID INT =  dbo.FUNC_CheckAuthorExists(@AuthorName)
	DECLARE @errorMsg nvarchar(max) = dbo.FUNC_CHECK_EMPLOYEE_VALUE(@Sex, @PhoneNumber, @CitizenID, @Wage , @CommissionRate)
	IF @errorMsg <> ''
	BEGIN
		RAISERROR(@errorMsg, 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	
    UPDATE Employee 
    SET FullName = @FullName, 
        Sex = @Sex, 
        FormatName = @FormatName, 
        Wage = @Wage, 
        EmployeeImage = @EmployeeImage, 
        PhoneNumber = @PhoneNumber, 
        Em_address = @Address, 
        CitizenID = @CitizenID, 
        CommissionRate = @CommissionRate, 
        DateOfBirth = @DateOfBirth, 
        Age = @Age, 
        AuthorID = @AuthorID
    WHERE employeeID = @employeeID

	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE PROD_DeleteEmployee
    @employeeID INT
AS
BEGIN
    UPDATE EMPLOYEE SET statusJob = 'Non-Active' WHERE employeeID = @employeeID;
END
GO


-- INSERT DATA FOR DATABASE
INSERT INTO AUTHORIZATION_USER VALUES (1, 'Manager');
INSERT INTO AUTHORIZATION_USER VALUES (2, 'Cashier');
GO

INSERT INTO WARRANTY_STATUS VALUES (1, 'NON-PROCESSED');
INSERT INTO WARRANTY_STATUS VALUES (2, 'PROCESSED');
GO

INSERT INTO EMPLOYEE(employeeID,fullName,formatName,phoneNumber,Em_address,citizenID,dateOfBirth,wage,sex,authorID,commissionRate,employeeImage)
values (1,'Nguyen Ngan','Full Time','0123456799','Ho Chi Minh','050303116553','2003-8-20',27000,'Female',1,0.5,'20230415135620453_45412b9b-d7b6-4fb9-8498-1fc5aa5648e5.png');
INSERT INTO EMPLOYEE(employeeID,fullName,formatName,phoneNumber,Em_address,citizenID,dateOfBirth,wage,sex,authorID,commissionRate,employeeImage)
values (2,'Nguyen Van Ba','Part Time','0123409799','Ho Chi Minh','050303116663','2003-8-20',23000,'Female',2,0.2,'20230415135628769_72dc12d9-7230-4aca-8c6e-0198ba3aa40c.png');
INSERT INTO EMPLOYEE(employeeID,fullName,formatName,phoneNumber,Em_address,citizenID,dateOfBirth,wage,sex,authorID,commissionRate,employeeImage)
values (3,'Nguyen A','Full Time','0123477799','Ho Chi Minh','050303110053','2003-8-20',21000,'Female',2,0.4,'20230415135647299_3994139f-fa20-4fe9-a062-3bb1b268e7c6.png');
GO

INSERT INTO CUSTOMER (phoneNumber, fullName, cus_address) VALUES ('0123456789', 'Nguyễn Văn A', '123 Đường ABC, Quận 1, TP. HCM');
INSERT INTO CUSTOMER (phoneNumber, fullName, cus_address) VALUES ('0987654321', 'Trần Thị B', '456 Đường XYZ, Quận 2, TP. HCM');
INSERT INTO CUSTOMER (phoneNumber, fullName, cus_address) VALUES ('0909090909', 'Lê Văn C', '789 Đường LMN, Quận 3, TP. HCM');

INSERT INTO PRODUCT (productID, productName, productImageURL, quantity) VALUES (1, 'Product A', NULL, 10);
INSERT INTO PRODUCT (productID, productName, productImageURL, quantity) VALUES (2, 'Product B', NULL, 15);
INSERT INTO PRODUCT (productID, productName, productImageURL, quantity) VALUES (3, 'Product C', NULL, 10);
INSERT INTO PRODUCT (productID, productName, productImageURL, quantity) VALUES (4, 'Product D', NULL, 20);

INSERT INTO BRAND (brandID, brandName) VALUES ('1', 'Brand A');
INSERT INTO BRAND (brandID, brandName) VALUES ('2', 'Brand B');
INSERT INTO BRAND (brandID, brandName) VALUES ('3', 'Brand C');

INSERT INTO PRODUCT_TYPE (typeID, typeName) VALUES ('1', 'Type A');
INSERT INTO PRODUCT_TYPE (typeID, typeName) VALUES ('2', 'Type B');
INSERT INTO PRODUCT_TYPE (typeID, typeName) VALUES ('3', 'Type C');

INSERT INTO PRODUCT_DETAIL (productID, typeID, brandID, importPrice, sellPrice, descript)
VALUES
    ('1', '1', '1', 100000, 150000, 'Product P001 - Type A - Brand A'),
    ('2', '2', '2', 120000, 180000, 'Product P002 - Type B - Brand B'),
    ('3', '3', '3', 90000, 140000, 'Product P003 - Type C - Brand C'),
    ('4', '1', '2', 110000, 170000, 'Product P004 - Type A - Brand B');

INSERT INTO BILL(billID, employeeID, phoneNumber, billExportTime)
VALUES ('1', 1, '0123456789', '2023-04-15'),
('2', 2, '0987654321', '2023-04-15'),
('3', 3, '0909090909', '2023-04-15');

INSERT INTO BILL_DETAIL (billID, productID, number) VALUES ('1', '1', 3);
INSERT INTO BILL_DETAIL (billID, productID, number) VALUES ('1', '2', 3);
INSERT INTO BILL_DETAIL (billID, productID, number) VALUES ('1', '3', 3);
INSERT INTO BILL_DETAIL (billID, productID, number) VALUES ('2', '1', 3);
INSERT INTO BILL_DETAIL (billID, productID, number) VALUES ('2', '2', 3);
INSERT INTO BILL_DETAIL (billID, productID, number) VALUES ('2', '3', 3);


UPDATE ACCOUNT
SET emp_password = 'admin123'
WHERE employeeID = 1
GO


--UPDATE
Create View View_Account
AS
	SELECT a.employeeID, fullName, emp_password
	FROM ACCOUNT a, EMPLOYEE e
	WHERE a.employeeID = e.employeeID
GO
CREATE PROCEDURE GetInforVoucher
@voucherID VARCHAR(15) = NULL,
@voucherName VARCHAR(255) = NULL,
@percentReduction FLOAT = NULL,
@statusVoucher VARCHAR(255) = NULL,
@expiryDate DATETIME = NULL,
@limitNumber INT = NULL,
@numberUsed INT = NULL
AS
BEGIN
	SELECT *
	FROM VIEW_VOUCHER
	WHERE   (@voucherID IS NULL OR voucherID = @voucherID)
		AND (@voucherName IS NULL OR [Name Voucher] = @voucherName)
		AND (@percentReduction IS  NULL OR [Percent Reduction ] = @percentReduction)
		AND (@statusVoucher IS NULL OR [Name of status] = @statusVoucher)
		AND (@expiryDate IS NULL OR expiryDate = @expiryDate)
 		AND (@limitNumber IS NULL OR limitNumber = @limitNumber)
		AND (@numberUsed IS NULL OR numberUsed = @numberUsed)
END
EXEC GetInforVoucher NULL, NULL, NULL, NULL, NULL, NULL, NULL
GO

--EXEC PROD_InsertEmployee
--    @FullName = 'Mai',
--    @Sex = 'FeMale',
--    @FormatName = 'Full Time',
--    @Wage = 27000.5,
--    @EmployeeImage = '20230415135312990_383f8789-49f8-4533-af40-81a7dec43f8d.png',
--    @PhoneNumber = '0123456795',
--    @Address = '123 Main Street',
--    @CitizenID = '030303110053',
--    @CommissionRate = 0.1,
--    @DateOfBirth = '2003-08-20',
--    @Age = 41,
--    @AuthorName = 'Manager'
--GO