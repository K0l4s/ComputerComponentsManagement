﻿using Dashboard.DAO;
using Dashboard.DTO;
using Dashboard.GUI.Panel;
using Dashboard.GUI.Panel.Account;
using Dashboard.GUI.Panel.Voucher;
using Dashboard.Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Dashboard : Form
    {
        private static Dashboard instance;

        public static Dashboard Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dashboard();
                return Dashboard.instance;
            }
            private set { Dashboard.instance = value; }
        }

        private Dashboard()
        {
            InitializeComponent();
            
        }

        private void Dashboard_Load()
        {
            this.WindowState = FormWindowState.Maximized;
            pMenu.Width = 250;
            //btnClick(new Account());
        }

        private void btnClick(object Fill, Button btnClick = null)
        {
            Form f = Fill as Form;
            Panel_Show(f);
            TransBackColor(btnBill, btnCustomer, btnEmployee, btnProduct, btnStatistic, btnVoucher);
            if (btnClick != null)
                btnClick.BackColor = Color.DarkGray;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pMenu.Width == 250)
            {
                pMenu.Width = 70;
                btnBill.Text = "";
                btnEmployee.Text = "";
                btnCustomer.Text = "";
                btnProduct.Text = "";
                btnStatistic.Text = "";
            }
            else
            {
                pMenu.Width = 250;
                btnBill.Text = "HÓA ĐƠN";
                btnEmployee.Text = "NHÂN VIÊN";
                btnCustomer.Text = "KHÁCH HÀNG";
                btnProduct.Text = "SẢN PHẨM";
                btnStatistic.Text = "THỐNG KÊ";
            }
        }

        private void Panel_Show(object Formhijo)
        {
            if (this.pCenter.Controls.Count > 0)
                this.pCenter.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pCenter.Controls.Add(fh);
            this.pCenter.Tag = fh;
            fh.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            btnClick(new fBill(), btnBill);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnClick(new Account());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            btnClick(new fEmployee(), btnEmployee);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnClick(new Customer(),btnCustomer);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            btnClick(new Product(), btnProduct);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            btnClick(new fStatistic(), btnStatistic);
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            btnClick(new Voucher(), btnVoucher);
        }
        
        private void TransBackColor(Button One, Button Two, Button Three, Button Four, Button Five, Button Six)
        {
            One.BackColor = Color.Transparent;
            Two.BackColor = Color.Transparent;
            Three.BackColor = Color.Transparent;
            Four.BackColor = Color.Transparent;
            Five.BackColor = Color.Transparent;
            Six.BackColor = Color.Transparent;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Dashboard_Load();
        }
    }
}
