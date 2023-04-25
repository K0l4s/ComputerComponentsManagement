using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            chartRevenueSpline.DataBind();
            DrawDoughtTop5(begin, end);
            DrawDoughBottom5(begin, end);
            DrawCharSpline(begin, end);

            int totalrevenue = StatisticsDAO.Instance.GetTotalRevenue(begin, end, ref err);
            lblTotalRevenue.Text = $"{totalrevenue}đ";

            int totalBill = StatisticsDAO.Instance.GetTotalBill(begin, end, ref err);
            lblAmountBill.Text = $"{totalBill}";

            int totalProduct = StatisticsDAO.Instance.GetTotalProduct(begin, end, ref err);
            lblAmountComponent.Text = $"{totalProduct}";
        }

        private void DrawDoughtTop5(DateTime begin, DateTime end)
        {
            String err = "";
            chartTopProducts.Series.Clear();
            DataTable dataTable = StatisticsDAO.Instance.GetTop5Product(begin, end, ref err);

            int totalSold = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalSold += Convert.ToInt32(row["totalSold"]);
            }
            chartTopProducts.Series.Clear(); // Xóa tất cả các series trên biểu đồ
            Series series1 = new Series("Series1");
            series1.ChartType = SeriesChartType.Doughnut;
            chartTopProducts.Series.Add(series1);
            foreach (DataRow row in dataTable.Rows)
            {
                double percentage = Convert.ToDouble(row["totalSold"]) / totalSold * 100;
                chartTopProducts.Series["Series1"].Points.AddXY(row["productName"], percentage);
            }
            chartTopProducts.DataBind();

        }

        private void DrawDoughBottom5(DateTime begin, DateTime end)
        {
            string err = "";
            chartBottomProducts.Series.Clear();
            DataTable dataTable = StatisticsDAO.Instance.GetTop5MinProduct(begin, end, ref err);

            int totalSold = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalSold += Convert.ToInt32(row["totalSold"]);
            }
            chartBottomProducts.Series.Clear(); // Xóa tất cả các series trên biểu đồ
            Series series1 = new Series("Series2");
            series1.ChartType = SeriesChartType.Doughnut;
            chartBottomProducts.Series.Add(series1);
            foreach (DataRow row in dataTable.Rows)
            {
                double percentage = Convert.ToDouble(row["totalSold"]) / totalSold * 100;
                chartBottomProducts.Series["Series2"].Points.AddXY(row["productName"], percentage);
            }
            chartBottomProducts.DataBind();

        }

        private void DrawCharSpline (DateTime begin, DateTime end) {
            string err = "";
            DataTable dataTable = StatisticsDAO.Instance.GetRevenueByDate(begin, end, ref err);
            chartRevenueSpline.Series["Revenue"].Points.Clear();
            if (dataTable.Rows.Count > 0)
            {
                //chartRevenueSpline.Series.Add("Revenue");
                //Series series1 = new Series("Revenue");
                //series1.ChartType = SeriesChartType.SplineArea;
                //chartRevenueSpline.Series.Add(series1);
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime date = row["date"] != DBNull.Value ? (DateTime)row["date"] : DateTime.MinValue;
                    int revenue = row["totalValue"] != DBNull.Value ? (int)row["totalValue"] : 0;
                    chartRevenueSpline.Series["Revenue"].Points.AddXY(date, revenue);
                }

                chartRevenueSpline.Series[0].XValueType = ChartValueType.DateTime;
                chartRevenueSpline.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                chartRevenueSpline.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";

            }
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
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian này");
            }
        }

    }
}
