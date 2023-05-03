using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.DAO
{
    public class WarrantyDAO
    {
        private static WarrantyDAO instance;

        public static WarrantyDAO Instance
        {
            get { if (instance == null) instance = new WarrantyDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable LoadTable(WarrantyDTO warran)
        {
            DataTable dt = null;

            string query = "SELECT * FROM searchWarranty ( @warrantyID , @productID , @billID , @quantity , @warr_StatusID )";
            object[] parameters = new object[] { warran.warrantyID,warran.productID,warran.billID,warran.quantity,warran.warr_statusID };
            dt = DataProvider.Instance.ExecuteQuery(query, parameters);
            return dt;
        }
        public DataTable GetListStatus()
        {
            DataTable dt = null;
            string query = "SELECT * FROM WARRANTY_STATUS";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public string AddWarranty(WarrantyDTO warr)
        {
            string err = "";
            int e;
            try
            {
                string query = "EXECUTE insertWarranty @warrantyID , @productID , @billID , @quantity , @warr_StatusID , @descript ";
                object[] parameters = new object[] { warr.warrantyID , warr.productID,warr.billID,warr.quantity,warr.warr_statusID,warr.descript };
                e = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = "Thêm bảo hành thành công!";
            }

            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string deleteWarranty(WarrantyDTO warr)
        {
            string err = "";
            int e;
            try
            {
                string query = "EXECUTE deleteWarranty @warrantyID ";
                object[] parameters = new object[] { warr.warrantyID };
                e = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = "Xóa bảo hành thành công!";
            }

            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string updateWarranty(WarrantyDTO warr)
        {
            string err = "";
            int e;
            try
            {
                string query = "EXECUTE updateWarranty @warrantyID , @productID , @billID , @quantity , @warr_StatusID , @descript ";
                object[] parameters = new object[] { warr.warrantyID, warr.productID, warr.billID, warr.quantity, warr.warr_statusID, warr.descript };
                e = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = "Cập nhật bảo hành thành công!";
            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
    }
}
