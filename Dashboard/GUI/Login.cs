using Dashboard.DAO;
using Dashboard.DTO;
using Dashboard.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            String employeeID = txtEmployeeID.Text;
            String password = txtPassword.Text;
            if (EmployeeDAO.Instance.Login(employeeID, password))
            {
                Dashboard.Instance.Show();
            }
            else 
                MessageBox.Show("Đăng nhập thất bại do tài khoản hoặc mật khẩu không khớp với cơ sở dữ liệu! Vui lòng kiểm tra lại hoặc liên hệ với QUẢN TRỊ VIÊN để được cấp quyền!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.DarkGray ;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void txtEmployeeID_Enter(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "MÃ NHÂN VIÊN")
                txtEmployeeID.Text = "";
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "")
                txtEmployeeID.Text = "MÃ NHÂN VIÊN";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "MẬT KHẨU")
                txtPassword.Text = "";
            if (txtPassword.UseSystemPasswordChar == false)
                txtPassword.UseSystemPasswordChar = true;
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "MẬT KHẨU";
                if (txtPassword.UseSystemPasswordChar == true)
                    txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void information_Click(object sender, EventArgs e)
        {
            MyTeam myteam = new MyTeam();
            myteam.Show();
        }
    }
}
