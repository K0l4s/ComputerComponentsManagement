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

namespace Dashboard.GUI.Panel.Account
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtRepeat.Text)
            {
                if(AccountDAO.Instance.ChangePassword(txtNewPass.Text, txtOldPass.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }    
            }
            else
                MessageBox.Show("Mật khẩu mới không khớp! Xin vui lòng kiểm tra lại!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtOldPass_Enter(object sender, EventArgs e)
        {
            if(txtOldPass.Text == "MẬT KHẨU CŨ")
            {
                txtOldPass.Text = "";
                txtOldPass.UseSystemPasswordChar = true;
            }    
        }

        private void txtOldPass_Leave(object sender, EventArgs e)
        {
            if(txtOldPass.Text == "")
            {
                txtOldPass.Text = "MẬT KHẨU CŨ";
                txtOldPass.UseSystemPasswordChar = false;
            }    
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "MẬT KHẨU MỚI")
            {
                txtNewPass.Text = "";
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "MẬT KHẨU MỚI";
                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void txtRepeat_Enter(object sender, EventArgs e)
        {
            if (txtRepeat.Text == "LẶP LẠI MẬT KHẨU MỚI")
            {
                txtRepeat.Text = "";
                txtRepeat.UseSystemPasswordChar = true;
            }
        }

        private void txtRepeat_Leave(object sender, EventArgs e)
        {
            if (txtRepeat.Text == "")
            {
                txtRepeat.Text = "LẶP LẠI MẬT KHẨU MỚI";
                txtRepeat.UseSystemPasswordChar = false;
            }
        }
    }
}
