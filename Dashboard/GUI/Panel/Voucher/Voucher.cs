using Dashboard.DAO;
using Dashboard.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dashboard.GUI.Panel.Voucher
{
    public partial class Voucher : Form
    {
        DataTable dta=null;
        private static Voucher instance;
        public static Voucher Instance
        {
            get { if (instance == null) instance = new Voucher(); return Voucher.instance; }
            private set { Voucher.instance = value; }
        }
        public Voucher()
        {
            InitializeComponent();
            
        }
        public DataTable LoadTable(string voucherID = null, string voucherName = null, int? percent = null, string statusVoucher = null, DateTime? expiryDate = null, int? limitNumber=null, int? numberUsed=null)
        {
            DataTable dt = null;
            
                string query = "EXEC GetInforVoucher @voucherID , @voucherName , @percent , @statusVoucher , @expiryDate , @limitNumber , @numberUsed";
                object[] parameters = new object[] { voucherID , voucherName, percent , statusVoucher , expiryDate , limitNumber , numberUsed };
                dt = DataProvider.Instance.ExecuteQuery(query, parameters);
            return dt;
        }

        private void Voucher_Load(object sender, EventArgs e)
        {
            panelTools.Visible = false;
            TableDefault();
        }
        private void TableDefault()
        {
            dta = LoadTable();
            dtgvTable.DataSource = dta;
        }
        private void btnCloseTool_Click(object sender, EventArgs e)
        {
            panelTools.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnTools.Text == "Tìm kiếm")
            {
                
                find_Info();
            }
        }
        private void find_Info()
        {

            string voucherID = null, voucherName = null, status = null;
                int? reduction = null;
                int? limit = null, used = null;
                DateTime? expiry = null;

            if (!String.IsNullOrEmpty(txtID.Text))
                voucherID = txtID.Text;
            if (!String.IsNullOrEmpty(txtName.Text))
                voucherName = txtName.Text;
            if(!String.IsNullOrEmpty(cbStatus.Text))
                status = cbStatus.Text;
            if (!String.IsNullOrEmpty(txtReduction.Text))
                try
                {
                    reduction = Int32.Parse(txtReduction.Text);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                }
            if (!String.IsNullOrEmpty(txtLimit.Text))
                try
                {
                    limit = Int32.Parse(txtLimit.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                }
            if (!String.IsNullOrEmpty(txtNumberUsed.Text))
                try
                {
                    used = Int32.Parse(txtNumberUsed.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                }
            if (!String.IsNullOrEmpty(txtDay.Text) || !String.IsNullOrEmpty(txtMonth.Text) || !String.IsNullOrEmpty(txtYear.Text))
                try
                {
                    expiry = new DateTime(Int32.Parse(txtYear.Text), Int32.Parse(txtMonth.Text), Int32.Parse(txtDay.Text));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                }

            MessageBox.Show("CHẠY ĐƯỢC");
                dta = LoadTable(voucherID, voucherName, reduction, status, expiry, limit, used);
                dtgvTable.DataSource = dta;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Tìm kiếm";
            panelTools.Visible = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Thêm";
            panelTools.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Xóa";
            panelTools.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Sửa";
            panelTools.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TableDefault();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtReduction.Text = null;
            cbStatus.Text = null;
            txtDay.Text = null;
            txtMonth.Text = null;
            txtLimit.Text = null;
            txtYear.Text = null;
            txtLimit.Text = null;
            txtNumberUsed.Text = null;
        }

        private void dtgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTable.Rows[e.RowIndex];
                string voucherID = row.Cells["voucherID"].Value.ToString();
                string voucherName = row.Cells["voucherName"].Value.ToString();
                DateTime? expiryDate = row.Cells["expiryDate"].Value as DateTime?;
                string status = row.Cells["status"].Value.ToString();
                string percentReduction = row.Cells["PercentReduction"].Value.ToString();
                string limitNumber = row.Cells["limitNumber"].Value.ToString();
                string numberUsed = row.Cells["numberUsed"].Value.ToString();
                txtID.Text = voucherID;
                txtName.Text = voucherName;
                cbStatus.Text = status;
                txtReduction.Text = percentReduction;
                txtLimit.Text = limitNumber;
                txtNumberUsed.Text = numberUsed;
                
                if (expiryDate.HasValue)
                {
                    txtDay.Text = expiryDate.GetValueOrDefault().Day.ToString();
                    txtMonth.Text = expiryDate.GetValueOrDefault().Month.ToString();
                    txtYear.Text = expiryDate.GetValueOrDefault().Year.ToString();
                }
                else
                {
                    txtDay.Text = "";
                    txtMonth.Text = "";
                    txtYear.Text = "";
                }
            }
        }
    }
}
