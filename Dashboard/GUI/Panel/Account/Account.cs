using Dashboard.DAO;
using Dashboard.DTO;
using Dashboard.GUI.Panel.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dashboard.Panel
{
    public partial class Account : Form
    {
        int userID;
        public Account()
        {
            InitializeComponent();
            userID = EmployeeDAO.userLogin;
            AccountLoad();
        }
        public void AccountLoad()
        {
            DataTable dt = EmployeeDAO.Instance.GetInforEmployeeByID();
            foreach (DataRow row in dt.Rows)
            {
                // Lấy giá trị của ô dữ liệu đầu tiên trong mỗi hàng
                txtEmployeeID.Text= row["EmloyeeID"].ToString();
                txtName.Text = row["FullName"].ToString();
                txtAuthor.Text = row["AuthorName"].ToString();
                cbbSex.Text = row["Sex"].ToString();
                cbbFormatEmp.Text = row["FormatName"].ToString();
                txtPhoneNumber.Text = row["PhoneNumber"].ToString();
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }
    }
}
