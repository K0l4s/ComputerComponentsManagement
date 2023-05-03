using Dashboard.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI
{
    public partial class BillView : Form
    {

        DateTime today = DateTime.Now;
        public BillView()
        {
            InitializeComponent();
        }

        private void BillView_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = new DateTime(today.Year,today.Month,DateTime.DaysInMonth(today.Year, today.Month),23,59,59);
            dtpStart.Value = new DateTime((dtpEnd.Value.Year),(dtpEnd.Value.Month),1,0,0,0);
            btnThisMonth.BackColor = Color.DeepSkyBlue;
            btn3Days.BackColor = Color.LightSlateGray;
            btnToday.BackColor = Color.LightSlateGray;
            btn7Days.BackColor = Color.LightSlateGray;
            searchBill();
        }
        private void searchBill()
        {
            string billID = null, phoneNumber = null;
            int? employeeID = null;
            DateTime? dayStart = dtpStart.Value;
            DateTime? dayEnd = dtpEnd.Value;
            if (!String.IsNullOrEmpty(txtID.Text))
                billID = txtID.Text;
            if (!String.IsNullOrEmpty(txtPhoneNo.Text))
                phoneNumber = txtPhoneNo.Text;
            if (!String.IsNullOrEmpty(txtBill.Text))
            {
                try
                {
                    employeeID = Int32.Parse(txtBill.Text);
                }
                catch(FormatException)
                {
                    MessageBox.Show("BillID nhập sai định dạng rồi!");
                }
            }
            DataTable dt = BillDAO.Instance.searchBill(billID,employeeID,dayStart,dayEnd);
            dgvBill.DataSource = dt;
            txtTotal.Text = (dgvBill.Rows.Count-1).ToString();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            txtTotal.Text = dgvBill.Rows.Count.ToString();
            dtpEnd.Value = new DateTime(today.Year, today.Month, today.Day,23,59,59);
            dtpStart.Value = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
            btnThisMonth.BackColor = Color.LightSlateGray;
            btn3Days.BackColor = Color.LightSlateGray;
            btnToday.BackColor = Color.DeepSkyBlue;
            btn7Days.BackColor = Color.LightSlateGray;
            searchBill();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            BillView_Load(null, null);
        }

        private void btn3Days_Click(object sender, EventArgs e)
        {
            dtpEnd.Value =new DateTime(today.Year, today.Month, today.Day, 23, 59, 59);
            dtpStart.Value = today.AddDays(-2);
            btnThisMonth.BackColor = Color.LightSlateGray;
            btn3Days.BackColor = Color.DeepSkyBlue;
            btnToday.BackColor = Color.LightSlateGray;
            btn7Days.BackColor = Color.LightSlateGray;
            searchBill();

        }

        private void btn7Days_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59);
            dtpStart.Value = today.AddDays(-7);
            btnThisMonth.BackColor = Color.LightSlateGray;
            btn3Days.BackColor = Color.LightSlateGray;
            btnToday.BackColor = Color.LightSlateGray;
            btn7Days.BackColor = Color.DeepSkyBlue;
            searchBill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchBill();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBill.Text = null;
            txtID.Text = null;
            txtPhoneNo.Text = null;
            BillView_Load(null, null);
        }
    }
}
