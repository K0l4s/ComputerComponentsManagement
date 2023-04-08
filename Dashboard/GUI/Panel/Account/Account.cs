using Dashboard.DAO;
using Dashboard.DTO;
using Dashboard.GUI.Panel.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dashboard.Panel
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            AccountLoad();
        }
        public void AccountLoad()
        {
            AccountDTO acc = AccountDAO.Instance.GetInforEmployeeByID();
            txtName.Text = acc.fullName;
            txtAuthor.Text = acc.role;
            txtEmployeeID.Text = acc.emloyeeID.ToString();
            //MessageBox.Show(acc.formatName);
            if (acc.sex == "Female")
            {
                cbbSex.SelectedIndex = 1;
            }
            else
                cbbSex.SelectedIndex = 0;
            if (acc.formatName == "Full Time")
            {
                cbbFormatEmp.SelectedIndex = 1;
            }
            else
                cbbFormatEmp.SelectedIndex = 0;
            txtPhoneNumber.Text = acc.phoneNumber;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }
    }
}
