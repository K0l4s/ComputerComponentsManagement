    using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dashboard.DAO
{
    public class EmployeeDAO
    {
        public string username;
        public static int userLogin { get; set; }
        private EmployeeDTO employeeDTO;
        private static string nameView = "view_Employee";
        private static string strSQL = "";
        private static List<SqlParameter> parameters;
        public static List<EmployeeDTO> employees = new List<EmployeeDTO>();
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }

        private EmployeeDAO() {}

        public bool Login(string username, string password)
        {
            DataProvider.UserName = username;
            DataProvider.Password = password;

            bool check = false;
            try
            {
                //MessageBox.Show(DataProvider.Instance.ConnStr);
                this.username  = username;
                String query = "SELECT * FROM View_Account WHERE employeeID = "+username+" AND emp_password = '"+password+"'";
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                userLogin = Int32.Parse(username);
                return result.Rows.Count > 0;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return check;

        }

        public bool ChangePassword(string newpass, string oldpass)
        {
            string query = "EXECUTE Change_Password @employeeID , @newPass , @oldPass ";
            object[] parameters = new object[] { userLogin, newpass, oldpass };
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 1)
                return true;
            else
                return false;
        }

        public DataTable GetInforEmployeeByID()
        {
            DataTable dt = new DataTable();
            string query = "EXECUTE GetInforEmployeeByID " + userLogin;
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetDataEmployee()
        {
            string query = "SELECT * FROM " + nameView;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddNewEmployee(EmployeeDTO employeeDTO, ref string err)
        {
            strSQL = "EXEC PROD_InsertEmployee @fullName , @sex , @formatName , @wage , @employeeImage , @phoneNumber , @address , @citizenID , @commissionRate , @dateOfBirth , @age , @authorName";

            object[] parameters = new object[]
            {
                employeeDTO.FullName,
                employeeDTO.Sex,
                employeeDTO.FormatName,
                employeeDTO.Wage,
                employeeDTO.EmployeeImage,
                employeeDTO.PhoneNumber,
                employeeDTO.Address,
                employeeDTO.CitizenID,
                employeeDTO.CommissionRate,
                employeeDTO.DateOfBirth.Date,
                employeeDTO.Age,
                employeeDTO.AuthorName
            };

            DataTable result = DataProvider.Instance.ExecuteQuery(strSQL, parameters);

            if (result.Rows.Count > 0)
            {
                err = result.Rows[0]["Error"].ToString();
                return false;
            }
            else
            {
                err = "Thêm Nhân Viên Thành Công !";
                return true;
            }
           
        }

        public bool DeleteEmployee(EmployeeDTO employeeDTO, ref string err)
        {
            string query = "EXECUTE PROD_DeleteEmployee @employeeID ";
            object[] parameters = new object[] { employeeDTO.EmployeeID };
            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);
            err = "Xóa nhân viên thành công";
            return true;
        }

        public bool UpdateEmployee(EmployeeDTO employeeDTO, ref string err)
        {
            //string query = "EXECUTE PROD_UpdateEmployee @employeeID, @fullName, @sex, @formatName, @wage, @employeeImage, @phoneNumber, @address, @citizenID, @commissionRate, @dateOfBirth, @age, @authorName";
            string query = "EXECUTE PROD_UpdateEmployee @employeeID , @fullName , @sex , @formatName , @wage , @employeeImage , @phoneNumber , @address , @citizenID , @commissionRate , @dateOfBirth , @age , @authorName";
            object[] parameters = new object[]
            {
                employeeDTO.EmployeeID,
                employeeDTO.FullName,
                employeeDTO.Sex,
                employeeDTO.FormatName,
                employeeDTO.Wage,
                employeeDTO.EmployeeImage,
                employeeDTO.PhoneNumber,
                employeeDTO.Address,
                employeeDTO.CitizenID,
                employeeDTO.CommissionRate,
                employeeDTO.DateOfBirth.Date,
                employeeDTO.Age,
                employeeDTO.AuthorName
            };
            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                err = result.Rows[0]["Error"].ToString();
                return false;
            }
            else
            {
                err = "Cập nhật thông tin nhân viên thành công!";
                return true;
            }
            
        }

    }
}
