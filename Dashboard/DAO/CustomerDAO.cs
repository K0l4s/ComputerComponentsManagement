using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LoadTable(string phoneNumber = null, string fullName = null, string cus_address = null)
        {
            DataTable dt = null;

            string query = "SELECT * FROM dbo.search_Customer ( @phoneNumber , @fullName , @cus_address )";
            object[] parameters = new object[] { phoneNumber, fullName, cus_address };
            dt = DataProvider.Instance.ExecuteQuery(query, parameters);
            return dt;
        }

        public string AddCustomer (string phoneNumber = null, string fullName = null, string cus_address = null)
        {
            string err = "";
            int e;
            try
            {
                string query = "EXECUTE insert_Customer @phoneNumber , @fullName , @cus_address ";
                object[] parameters = new object[] { phoneNumber, fullName, cus_address };
                e = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = "Tạo tài khoản thành công";
            }

            catch (SqlException ex)
            {
                err = ex.Message;
            } 
            return err;
        }

        public string DeleteCustomer (string phoneNumber = null, string fullName = null, string cus_address = null)
        {
            string err = "";
            int e;
            try
            {
                string query = "EXECUTE delete_Customer @phoneNumber";
                object[] parameters = new object[] { phoneNumber };
                e = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = "Xóa tài khoản thành công";
            }
            catch(SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }

        public string UpdateCustomer(string phoneNumber = null, string fullName = null, string cus_address = null)
        {
            string err = "";
            int e;
            try
            {
                string query = "EXECUTE update_Customer @phoneNumber , @fullName , @cus_address";
                object[] parameters = new object[] { phoneNumber, fullName, cus_address };
                e = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = "Cập nhật tài khoản thành công";
            }
            catch(SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
    }
}
