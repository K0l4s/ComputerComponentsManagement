using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI.Panel
{
    public partial class fStatistic : Form
    {
        public static DataTable charData ;

        public fStatistic()
        {
            InitializeComponent();
        }

        private void LoadData(DateTime begin, DateTime end)
        {
            string err = "";
            //chartGrossRevenue.DataBind();
            //chartTopProducts.DataBind();


            //revenue = new Revenue();
            //dtCategory = revenue.getRevenue(begin, end, ref err);
            //chartGrossRevenue.DataSource = dtCategory;
            //chartGrossRevenue.Series["Series1"].XValueMember = "dateOfBill";
            //chartGrossRevenue.Series["Series1"].YValueMembers = "total";

            //revenue = new Revenue();
            charData= StatisticsDAO.Instance.GetTop5Product(begin, end, ref err);
            chartTopProducts.DataSource = charData;
            MessageBox.Show(err);
            chartTopProducts.Series["Series1"].XValueMember = "nameBook";
            chartTopProducts.Series["Series1"].YValueMembers = "amountOutput";


            //revenue = new Revenue();
            //dtCategory = revenue.getTop5MinStock();
            //chartMinStock.DataSource = dtCategory;
            //chartMinStock.Series["Series1"].XValueMember = "nameBook";
            //chartMinStock.Series["Series1"].YValueMembers = "amount";

            //revenue = new Revenue();
            int totalrevenue = StatisticsDAO.Instance.GetTotalRevenue(begin, end, ref err);
            lblTotalRevenue.Text = $"{totalrevenue}đ";

            int totalBill = StatisticsDAO.Instance.GetTotalBill(begin, end, ref err);
            lblAmountBill.Text = $"{totalBill}";

            int totalProduct = StatisticsDAO.Instance.GetTotalProduct(begin, end, ref err);
            lblAmountComponent.Text = $"{totalProduct}";

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            this.dtpStartDate.Value = DateTime.Today;
            this.dtpEndDate.Value = DateTime.Now;
            try
            {
                LoadData(dtpStartDate.Value, dtpEndDate.Value);
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu trong ngày hôm nay");
            }
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            this.dtpStartDate.Value = DateTime.Now.AddDays(-7);
            this.dtpEndDate.Value = DateTime.Now;
            try
            {
                LoadData(dtpStartDate.Value, dtpEndDate.Value);
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu trong tuần vừa qua");
            }
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            this.dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.dtpEndDate.Value = DateTime.Now;

            try
            {
                LoadData(dtpStartDate.Value, dtpEndDate.Value);
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu trong tháng này");
            }
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            btnCustomDate.Enabled=false;
            btnToday.Enabled = false;
            btnLast7Days.Enabled = false;
            btnThisMonth.Enabled = false;
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData(this.dtpStartDate.Value, this.dtpEndDate.Value);
                btnOK.Visible = false;
                btnCustomDate.Enabled = true;
                btnToday.Enabled = true;
                btnLast7Days.Enabled = true;
                btnThisMonth.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian này");
            }
        }

    }
}
