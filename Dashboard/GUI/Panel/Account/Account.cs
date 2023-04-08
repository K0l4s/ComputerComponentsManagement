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
            EmployeeDTO acc = EmployeeDAO.Instance.GetInforEmployeeByID();
            txtName.Text = acc.FullName;
            txtAuthor.Text = acc.AuthorName;
            txtEmployeeID.Text = acc.EmloyeeID.ToString();
            //MessageBox.Show(acc.formatName);
            if (acc.Sex == "Female")
            {
                cbbSex.SelectedIndex = 1;
            }
            else
                cbbSex.SelectedIndex = 0;
            if (acc.FormatName == "Full Time")
            {
                cbbFormatEmp.SelectedIndex = 1;
            }
            else
                cbbFormatEmp.SelectedIndex = 0;
            txtPhoneNumber.Text = acc.PhoneNumber;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }
    }
}
