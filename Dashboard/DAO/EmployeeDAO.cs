using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.DAO
{
    public class EmployeeDAO
    {
        private string username;
        public List<EmployeeDTO> employees = new List<EmployeeDTO>();
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }

        private EmployeeDAO() { }

        public bool Login(string username, string password)
        {
            this.username = username;
            String query = "SELECT * FROM ACCOUNT WHERE employeeID = "+username+" AND emp_password = '"+password+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
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

        public EmployeeDTO GetInforEmployeeByID()
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

                //EmployeeDTO account = new EmployeeDTO(employeeID, fullName, sex, dateOfBirth, employeeImage, formatName,phoneNumber, address, citizenID, age, statusJob, role)
                //return account;
            }
            return null;
        }

    }
}
