#Description
This project is submit the course "Database Management System"
#Teammate
1. Huỳnh Trung Kiên (me - Leader)
2. Nguyễn Hoàng Phương Ngân
3. Nguyễn Bùi Minh Nhật
4. Nguyễn Quốc Long




# Cách connect tới database:
Bước 1: Trước hết bạn chạy file dưới trong SQL Server
```
MainSQL.sql
```
Bước 2: Sau đó mở file
```
Dashboard.sln
```
trong Visual Code Studio và nhấn nút Run để test chương trình. Nếu lỗi liên quan tới database (không kết nối được hoặc không đăng nhập được) thì tiến hành xóa Database vừa mới khởi tạo và chạy file
```
MainSQL2.sql
```
rồi thực hiện lại từ bước 2




# Cách làm việc với git
## Mới bắt đầu code
Trước khi bắt đầu code thì dùng dòng lệnh dưới đây trước
```
git pull
```
Dòng lệnh trên để tải về thay đổi mới nhất của project . Nếu không sử dụng thì về sau sẽ bị trường hợp "Khi upload code mình vừa làm mà người khác làm thay đổi gì cùng chỗ đó thì sẽ bị conflict nghĩa là nó không biết chọn thay đổi nào để thống nhất "


## Sau khi code xong
Thực hiện lần lược các câu lệnh sau 
```
git add .
```
```
git commit -m "toi vua hoan thanh phan ... "
```
```
git pull 
```
```
git push 
```


## Trường hợp bị conflict nặng 
Tạo thư mục khác và mở cmd tại đường dẫn và tải project về lại

```
git clone https://github.com/trunqkien/ComputerComponentsManagement.git
```
