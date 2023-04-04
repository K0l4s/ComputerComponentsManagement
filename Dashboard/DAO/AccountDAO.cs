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
        private string username;
        public List<AccountDTO> employees = new List<AccountDTO>();
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
        public AccountDTO GetInforEmployeeByID()
        {
            DataTable dt = new DataTable();
            string query = "EXECUTE GetInforEmployeeByID " + username;
            dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int employeeID = (int)row["EmployeeID"];
                string fullName = row["FullName"].ToString();
                string sex = row["Sex"].ToString();
                DateTime dateOfBirth = (DateTime)row["DateOfBirth"];
                byte[] employeeImage = null;
                string formatName = row["FormatName"].ToString();
                string address = row["Address"].ToString();
                string citizenID = row["CitizenID"].ToString();
                int age = (int)row["Age"];
                string statusJob = row["StatusJob"].ToString();
                string role = row["Role"].ToString();

                AccountDTO account = new AccountDTO(employeeID, fullName, sex, dateOfBirth, employeeImage, formatName, address, citizenID, age, statusJob, role);
                return account;
            }
            return null;
        }
    }
}
