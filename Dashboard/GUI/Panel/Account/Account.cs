﻿using Dashboard.DAO;
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

        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }
    }
}
