using Dashboard.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dashboard.GUI.Panel
{
    public partial class fSalary : Form
    {
        DataTable dta = null;
        private static fSalary instance;
        public static fSalary Instance
        {
            get { if (instance == null) instance = new fSalary(); return fSalary.instance; }
            private set { fSalary.instance = value; }
        }

        public fSalary()
        {
            InitializeComponent();
            TableDefault();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            TableDefault();
        }

        private void TableDefault()
        {
            DateTime defaultStart = dateTimePicker1.Value; // set default dayStart value
            DateTime defaultEnd = dateTimePicker2.Value; // set default dayEnd value
            dta = SalaryDAO.Instance.LoadTable(defaultStart, defaultEnd);
            dtvSalary.DataSource = dta;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime dayStart = dateTimePicker1.Value;
            DateTime dayEnd = dateTimePicker2.Value;

            if(String.IsNullOrEmpty(txtEm_ID.Text)) //Nếu ô txt.Em_ID để trống (null) thì khi nhấn "Tìm kiếm" sẽ hiển thị tất cả nhân viên trong khoảng thời gian tùy chọn, LoadTable
            {
                dta = SalaryDAO.Instance.LoadTable(dayStart, dayEnd);
                dtvSalary.DataSource = dta;
            }       
            else//Ngược lại, nếu nhập ID nhân viên cụ thể vào ô txt.Em_ID thì sẽ hiển thị ra thông tin lương của 1 nhân viên đó trong khoảng thời gian tùy chọn
            {
                find_Info();
            }

            
        }

        private void find_Info()
        {
            try
            {
                DateTime dayStart = dateTimePicker1.Value;
                DateTime dayEnd = dateTimePicker2.Value;
                int employeeID = Int32.Parse(txtEm_ID.Text);

                if (!String.IsNullOrEmpty(txtEm_ID.Text))
                    try
                    {
                        employeeID = Int32.Parse(txtEm_ID.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }

                dta = SalaryDAO.Instance.SearchTable( employeeID , dayStart , dayEnd);
                dtvSalary.DataSource = dta;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lẽ bạn gặp phải lỗi rồi. Liên hệ DEVELOPER để được hỗ trợ nhé! \n Nội dung lỗi:" + ex.Message);

            }
        }
    }
}