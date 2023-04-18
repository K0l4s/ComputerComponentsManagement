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

namespace Dashboard.GUI.Panel.Account
{
    public partial class Customer : Form
    {
        DataTable dta = null;
        private static Customer instance;
        public static Customer Instance
        {
            get { if (instance == null) instance = new Customer(); return Customer.instance; }
            private set { Customer.instance = value; }
        }
        
        public Customer()
        {
            InitializeComponent();
            TableDefault();
        }

        

        private void Customer_Load(object sender, EventArgs e)
        {
            panelTools.Visible = false;

            TableDefault();
        }

        private void TableDefault()
        {
            dta = CustomerDAO.Instance.LoadTable();
            // Lặp qua các hàng trong DataTable
            dtgvTable.DataSource = dta;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Info()
        {
            string phoneNumber = null, fullName = null, cus_address = null;
            if (!String.IsNullOrEmpty(txtPhoneNo.Text))
                phoneNumber = txtPhoneNo.Text;
            if (!String.IsNullOrEmpty(txtFullName.Text))
                fullName = txtFullName.Text;
            if (!String.IsNullOrEmpty(txtCus_Add.Text))
                cus_address = txtCus_Add.Text;
            string err = CustomerDAO.Instance.AddCustomer(phoneNumber, fullName, cus_address);
            MessageBox.Show(err);
            TableDefault();
        }

        private void delete_Info()
        {
            string phoneNumber = null;
            if (!String.IsNullOrEmpty(txtPhoneNo.Text))
                phoneNumber = txtPhoneNo.Text;
            string err = CustomerDAO.Instance.DeleteCustomer(phoneNumber);
            MessageBox.Show(err);
            TableDefault();
        }

        public void update_Info()
        {
            string phoneNumber = null, fullName = null, cus_address = null;
            if (!String.IsNullOrEmpty(txtPhoneNo.Text))
                phoneNumber = txtPhoneNo.Text;
            if (!String.IsNullOrEmpty(txtFullName.Text))
                fullName = txtFullName.Text;
            if (!String.IsNullOrEmpty(txtCus_Add.Text))
                cus_address = txtCus_Add.Text;
            string err = CustomerDAO.Instance.UpdateCustomer(phoneNumber, fullName, cus_address);
            MessageBox.Show(err);
            TableDefault();
        }

        private void find_Info ()
        {
            try
            {
                string phoneNumber = null, fullName = null, cus_address = null;
                if(!String.IsNullOrEmpty(txtPhoneNo.Text))
                    phoneNumber = txtPhoneNo.Text;
                if(!String.IsNullOrEmpty(txtFullName.Text))
                    fullName = txtFullName.Text;
                if (!String.IsNullOrEmpty(txtCus_Add.Text))
                    cus_address = txtCus_Add.Text;
                dta = CustomerDAO.Instance.LoadTable(phoneNumber, fullName, cus_address);
                dtgvTable.DataSource = dta;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi của bạn có thể từ dữ liệu. Thử lại nhé! \n Mã lỗi:" + ex.ErrorCode + "\n Nội dung: " + ex.Errors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lẽ bạn gặp phải lỗi rồi. Liên hệ DEVELOPER để được hỗ trợ nhé! \n Nội dung lỗi:" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Tìm kiếm";
            panelTools.Visible = true;
            txtPhoneNo.Enabled = true;
            txtFullName.Enabled = true;
            txtCus_Add.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Thêm";
            panelTools.Visible = true;
            txtPhoneNo.Enabled = true;
            txtFullName.Enabled = true;
            txtCus_Add.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Xóa";
            panelTools.Visible = true;
            txtPhoneNo.Enabled = true;
            txtFullName.Enabled = false;
            txtCus_Add.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Sửa";
            panelTools.Visible = true;
            txtPhoneNo.Enabled = true;
            txtFullName.Enabled = true;
            txtCus_Add.Enabled = true;
        }

        private void btnCloseTool_Click(object sender, EventArgs e)
        {
            panelTools.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TableDefault();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            if(btnTools.Text == "Tìm kiếm")
            {
                find_Info();
            }
            else if (btnTools.Text == "Thêm")
            {
                add_Info();
            }
            else if(btnTools.Text == "Xóa")
            {
                delete_Info();
            }
            else if (btnTools.Text == "Sửa")
            {
                update_Info();
            }
        }

        private void dtgvTable__CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//Để tránh lấy tên của cột
            {
                DataGridViewRow row = this.dtgvTable.Rows[e.RowIndex];
                string phoneNumber = row.Cells["phoneNumber"].Value.ToString();
                string fullName = row.Cells["fullName"].Value.ToString();
                string cus_address = row.Cells["cus_address"].Value.ToString();
                
                txtPhoneNo.Text = phoneNumber;
                txtFullName.Text = fullName;
                txtCus_Add.Text = cus_address;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhoneNo.Text = null;
            txtFullName.Text = null;
            txtCus_Add.Text = null;
        }
    }
}
