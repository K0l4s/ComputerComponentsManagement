using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance { 
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO()
        {

        }
        public static DataTable ToDataTable(AccountDTO account)
        {
            DataTable dataTable = new DataTable();

            // Lấy tất cả các thuộc tính của đối tượng AccountDTO
            PropertyInfo[] properties = typeof(AccountDTO).GetProperties();

            // Thêm các cột vào DataTable dựa trên các thuộc tính của đối tượng AccountDTO
            foreach (PropertyInfo property in properties)
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }

            // Thêm hàng dữ liệu vào DataTable
            DataRow dataRow = dataTable.NewRow();
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(account);
                dataRow[property.Name] = value ?? DBNull.Value;
            }
            dataTable.Rows.Add(dataRow);
            return dataTable;
        }
        public static AccountDTO ConvertDataTableToDTO(DataTable dt)
        {
            DataRow row = dt.Rows[0];
            int employeeID = Convert.ToInt32(row["EmployeeID"]);
            string fullName = row["FullName"].ToString();
            string sex = row["Sex"].ToString();
            DateTime dateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
            byte[] employeeImage = (byte[])row["EmployeeImage"];
            string phoneNumber = row["PhoneNumber"].ToString();
            string formatName = row["FormatName"].ToString();
            string address = row["Address"].ToString();
            string citizenID = row["CitizenID"].ToString();
            int age = Convert.ToInt32(row["Age"]);
            string statusJob = row["StatusJob"].ToString();
            string role = row["Role"].ToString();
            return new AccountDTO(employeeID,fullName,sex,dateOfBirth,employeeImage,phoneNumber,formatName,address,citizenID,age,statusJob,role);
        }
        private string username;
        public List<AccountDTO> employees = new List<AccountDTO>();
        public bool Login(string username, string password)
        {
            this.username = username;
            String query = "Select * From View_Employee";
            DataTable result = DataProvider.Instance.ExecuteQuery(query) ;
            return result.Rows.Count > 0;
        }
        public bool ChangePassword(string newpass, string oldpass)
        {
            string query = "EXECUTE Change_Password "+username+" , '"+newpass+"' , '"+oldpass+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 1)
                return true;
            else
                return false;
        }
        public AccountDTO GetInforEmployeeByID()
        {
            DataTable dt = new DataTable();
            string query = "EXECUTE GetInforEmployeeByID " + username;
            dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int employeeID = (int)row["employeeID"];
                string fullName = row["fullName"].ToString();
                string sex = row["sex"].ToString();
                DateTime dateOfBirth = (DateTime)row["dateOfBirth"];
                byte[] employeeImage;
                if (row["employeeImage"] == DBNull.Value)
                {
                    // Giá trị từ cơ sở dữ liệu là DBNull, thực hiện xử lý đặc biệt hoặc bỏ qua
                    byte[] defaultValue = new byte[0]; // Giá trị mặc định cho mảng byte
                                                       // Hoặc
                                                       // byte[] defaultValue = null; // Hoặc giá trị null cho mảng byte
                                                       // Hoặc thực hiện xử lý khác tùy theo logic của bạn
                    employeeImage = defaultValue; // Gán giá trị đặc biệt cho mảng byte
                }
                else
                {
                    // Giá trị từ cơ sở dữ liệu không phải là DBNull, thực hiện ép kiểu bình thường
                    employeeImage = (byte[])row["employeeImage"];
                    // Tiếp tục xử lý với giá trị ép kiểu thành công
                }
                string phoneNumber = row["phoneNumber"].ToString();
                string formatName = row["formatName"].ToString();
                string address = row["address"].ToString();
                string citizenID = row["citizenID"].ToString();
                int age = (int)row["age"];
                string statusJob = row["statusJob"].ToString();
                string role = row["role"].ToString();

                AccountDTO account = new AccountDTO(employeeID, fullName, sex, dateOfBirth, employeeImage, formatName,phoneNumber, address, citizenID, age, statusJob, role);
                return account;
            }
            return null;
        }
    }
}
