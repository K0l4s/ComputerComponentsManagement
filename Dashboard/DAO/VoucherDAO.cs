using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard.DTO;

namespace Dashboard.DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO instance;

        public static VoucherDAO Instance
        {
            get { if (instance == null) instance = new VoucherDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LoadTable(string voucherID = null, string voucherName = null, int? percent = null, string statusVoucher = null, DateTime? expiryDate = null, int? limitNumber = null, int? numberUsed = null)
        {
            DataTable dt = null;

            string query = "Select * FROM GetInforVoucher ( @voucherID , @voucherName , @percent , @statusVoucher , @expiryDate , @limitNumber , @numberUsed )";
            object[] parameters = new object[] { voucherID, voucherName, percent, statusVoucher, expiryDate, limitNumber, numberUsed };
            dt = DataProvider.Instance.ExecuteQuery(query, parameters);
            return dt;
        }
        public string AddVoucher(string voucherID = null, string voucherName = null, int? percent = null, string statusVoucher = null, DateTime? expiryDate = null, int? limitNumber = null, int? numberUsed = null)
        {
            string err = "";
            int e;
            try
            {
                string query = "EXECUTE InsertVoucher @voucherID , @voucherName , @percent , @statusVoucher , @expiryDate , @limitNumber , @numberUsed ";
                object[] parameters = new object[] { voucherID , voucherName , percent , statusVoucher , expiryDate , limitNumber , numberUsed };
                e = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = "Tạo voucher mới thành công";
            }

            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
    }
}
