using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private VoucherDAO() { }

        public DataTable LoadTable(string voucherID, string voucherName, string percentReduction,string status, string expiryDate, string limitNumber, string numberUsed)
        {
            //percentReduction;
            //expiryDate.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "EXEC GetInforVoucher "+voucherID+" , "+voucherName + " , " + percentReduction + " , " + status + " , " + expiryDate + " , " + limitNumber + " , " +numberUsed;
            MessageBox.Show(query);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
