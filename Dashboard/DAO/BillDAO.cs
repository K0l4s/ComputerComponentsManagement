using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable searchBill(string billID = null, int? employeeID = null,DateTime? dayStart = null, DateTime? dayEnd = null)
        {
            string query = "SELECT * FROM searchBill ( @billID , @employeeID , @dayStart , @dayEnd )";
            object[] parameters = new object[] { billID, employeeID, dayStart, dayEnd } ;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, parameters);
            return dt;
        }
        //@billID VARCHAR(20) = NULL, @employeeID VARCHAR(36)= NULL, @phoneNumber VARCHAR(10) =NULL, @billExportTime DATETIME = NULL
        public string addProduct(string billID=null,int? employeeID = null, string phoneNumber = null,DateTime? billExportTime =null)
        {
            string err;
            try
            {
                string query = "EXECUTE insertBill @billID , @employeeID , @phoneNumber , @billExportTime ";
                object[] parameters = new object[]{ billID, employeeID, phoneNumber, billExportTime };
                int dt = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = null;
            }
            catch(SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string addItem(string billID = null, string productID = null,int? quantity = null)
        {
            string err;
            try
            {
                string query = "EXECUTE insertProductInBill @billID , @productID , @quantity ";
                object[] parameters = new object[] { billID, productID, quantity };
                int dt = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = null;
            }

            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string addVoucher(string billID = null, string voucherID = null)
        {
            string err;
            try
            {
                string query = "EXECUTE insertVoucherApply @billID , @voucherID ";
                object[] parameters = new object[] { billID, voucherID };
                int dt = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = null;
            }

            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
    }
}
