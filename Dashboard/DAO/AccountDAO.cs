using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
