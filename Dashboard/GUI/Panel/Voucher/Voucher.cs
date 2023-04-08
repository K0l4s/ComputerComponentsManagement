using Dashboard.DAO;
using Dashboard.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public DataTable LoadTable(string voucherID = "NULL", string voucherName = "NULL", string percentReduction = "NULL", string status = "NULL", string expiryDate = "NULL", string limitNumber = "NULL", string numberUsed = "NULL")
        {
            if(voucherID is null || voucherID == "")
                voucherID = "NULL";   
            if(voucherName is null || voucherName == "")
                voucherName ="NULL";  
            if(percentReduction is null || percentReduction == "")
                percentReduction = "NULL"; 
            if(status is null || status == "")
                status = "NULL";  
            if(expiryDate is null || expiryDate == "--")
                expiryDate = "NULL";   
            if(limitNumber is null || limitNumber == "")
                limitNumber = "NULL";
            if(numberUsed is null || numberUsed == "")
                numberUsed = "NULL";
            string query = "EXEC GetInforVoucher " + voucherID + " , " + voucherName + " , " + percentReduction + " , " + status + " , " + expiryDate + " , " + limitNumber + " , " + numberUsed;
            //MessageBox.Show(query);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
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
            string voucherID = txtID.Text, voucherName = txtName.Text, reduction = txtReduction.Text, 
                status = cbStatus.Text, expiry ,
                limit = txtLimit.Text, used = txtNumberUsed.Text;
            if (txtDay.Text == "" || txtMonth.Text == "" || txtYear.Text == "")
                expiry = "NULL";
            else
                expiry = "'" + txtYear.Text + "-" + txtMonth.Text + "-" + txtDay.Text +"'";
            dta = LoadTable(voucherID, voucherName,reduction,status,expiry,limit,used);
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
    }
}
