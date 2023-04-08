using Dashboard.DAO;
using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI.Panel.Voucher
{
    public partial class Voucher : Form
    {
        public Voucher()
        {
            InitializeComponent();
            //VoucherLoad();
        }
        private void Panel_Show(object Formhijo)
        {
            if (this.pCenter.Controls.Count > 0)
                this.pCenter.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pCenter.Controls.Add(fh);
            this.pCenter.Tag = fh;
            fh.Show();
        }
        private void VoucherLoad()
        {
            //string query = "EXEC GetInforVoucher NULL, NULL, NULL, NULL, NULL, NULL, NULL";
            //DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DataTable dta = VoucherDAO.Instance.LoadTable("NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL");
            Panel_Show(new VoucherTable(dta));
        }
        public void TableCall(VoucherDTO dt)
        {
            string voucherID = "NULL", voucherName = "NULL", percentReduction = "NULL", status = "NULL", expiry = "NULL", limitNumber = "NULL", usedNum = "NULL";
            if(dt.voucherID != null)
            {
                voucherID = "'"+dt.voucherID+"'";
            }
            if(dt.voucherName != null)
            { 
                voucherName = "'"+dt.voucherName+"'";
            }
            if(dt.percentReduction != -1)
            {
                percentReduction = dt.percentReduction.ToString();
            }
            if(dt.status != null)
            {
                if (dt.status.ToString() == "Còn HSD")
                    status = "'Con HSD'";
                else
                    status = "'Qua HSD'";
            }
            if(dt.expiryDate != new DateTime(01, 01, 0001, 12, 0, 0, 0))
            {
                expiry = "'"+dt.expiryDate.ToString("yyyy-MM-dd HH:mm:ss")+"'";
            }
            if(dt.limitNumber != -2)
            {
                limitNumber = dt.limitNumber.ToString();
            }
            if(dt.numberUsed != -2)
            {
                usedNum = dt.numberUsed.ToString();
            }
            MessageBox.Show(voucherID + voucherName);
            DataTable dta = VoucherDAO.Instance.LoadTable(voucherID , voucherName , percentReduction , status , expiry , limitNumber , usedNum);
            if (this.pCenter.Controls.Count > 0)
                this.pCenter.Controls.RemoveAt(0);
            Panel_Show(new VoucherTable(dta));
            dt1.DataSource = dta;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            VoucherSearch search = new VoucherSearch();
            search.Show();
        }

        private void Voucher_Load(object sender, EventArgs e)
        {
            VoucherLoad();
        }
    }
}
