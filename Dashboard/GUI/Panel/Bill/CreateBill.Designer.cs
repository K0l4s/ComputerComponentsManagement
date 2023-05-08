namespace Dashboard.GUI
{
    partial class CreateBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCanel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVouID = new System.Windows.Forms.TextBox();
            this.voucherCheck = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReduction = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtBillID = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnCustomerCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDone = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalMoney = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.panelTable.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1000, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 633);
            this.panel2.TabIndex = 1;
            // 
            // panelTable
            // 
            this.panelTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTable.Controls.Add(this.panelAdd);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(0, 0);
            this.panelTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1000, 633);
            this.panelTable.TabIndex = 4;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelAdd.Controls.Add(this.flowLayoutPanel1);
            this.panelAdd.Controls.Add(this.panel3);
            this.panelAdd.Controls.Add(this.panel1);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(0, 0);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(1000, 633);
            this.panelAdd.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnAddProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 193);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 374);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlAdded);
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlRemoved);
            this.flowLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseClick);
            this.flowLayoutPanel1.MouseHover += new System.EventHandler(this.flowLayoutPanel1_MouseHover);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 2);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(316, 363);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm sản phấm";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnCanel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtBillID);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnAddCustomer);
            this.panel3.Controls.Add(this.txtPhoneNo);
            this.panel3.Controls.Add(this.txtCustomer);
            this.panel3.Controls.Add(this.btnCustomerCheck);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 193);
            this.panel3.TabIndex = 3;
            // 
            // btnCanel
            // 
            this.btnCanel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCanel.Location = new System.Drawing.Point(435, 150);
            this.btnCanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(64, 28);
            this.btnCanel.TabIndex = 28;
            this.btnCanel.Text = "HỦY";
            this.btnCanel.UseVisualStyleBackColor = false;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtVouID);
            this.panel4.Controls.Add(this.voucherCheck);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtReduction);
            this.panel4.Controls.Add(this.txtEmployeeID);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtDay);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtMonth);
            this.panel4.Controls.Add(this.txtYear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(505, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 193);
            this.panel4.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "NGÀY LẬP HÓA ĐƠN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "MÃ NHÂN VIÊN LẬP HÓA ĐƠN:";
            // 
            // txtVouID
            // 
            this.txtVouID.Location = new System.Drawing.Point(142, 93);
            this.txtVouID.Margin = new System.Windows.Forms.Padding(4);
            this.txtVouID.Name = "txtVouID";
            this.txtVouID.Size = new System.Drawing.Size(145, 22);
            this.txtVouID.TabIndex = 26;
            // 
            // voucherCheck
            // 
            this.voucherCheck.BackColor = System.Drawing.Color.Wheat;
            this.voucherCheck.Location = new System.Drawing.Point(30, 139);
            this.voucherCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voucherCheck.Name = "voucherCheck";
            this.voucherCheck.Size = new System.Drawing.Size(425, 39);
            this.voucherCheck.TabIndex = 5;
            this.voucherCheck.Text = "KIỂM TRA VOUCHER";
            this.voucherCheck.UseVisualStyleBackColor = false;
            this.voucherCheck.Click += new System.EventHandler(this.voucherCheck_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "MÃ VOUCHER:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "GIẢM:";
            // 
            // txtReduction
            // 
            this.txtReduction.Enabled = false;
            this.txtReduction.Location = new System.Drawing.Point(342, 93);
            this.txtReduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReduction.Name = "txtReduction";
            this.txtReduction.Size = new System.Drawing.Size(95, 22);
            this.txtReduction.TabIndex = 12;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Location = new System.Drawing.Point(247, 59);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(207, 22);
            this.txtEmployeeID.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "/";
            // 
            // txtDay
            // 
            this.txtDay.Enabled = false;
            this.txtDay.Location = new System.Drawing.Point(187, 22);
            this.txtDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(59, 22);
            this.txtDay.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "/";
            // 
            // txtMonth
            // 
            this.txtMonth.Enabled = false;
            this.txtMonth.Location = new System.Drawing.Point(275, 22);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(71, 22);
            this.txtMonth.TabIndex = 15;
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(373, 22);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(81, 22);
            this.txtYear.TabIndex = 16;
            // 
            // txtBillID
            // 
            this.txtBillID.FormattingEnabled = true;
            this.txtBillID.Location = new System.Drawing.Point(79, 23);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(348, 24);
            this.txtBillID.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(183, 86);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(243, 22);
            this.txtAddress.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "ĐỊA CHỈ KHÁCH HÀNG:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Honeydew;
            this.btnAddCustomer.Location = new System.Drawing.Point(219, 150);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(209, 28);
            this.btnAddCustomer.TabIndex = 23;
            this.btnAddCustomer.Text = "Thêm Khách Hàng Mới";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(237, 119);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(189, 22);
            this.txtPhoneNo.TabIndex = 10;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(160, 54);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(267, 22);
            this.txtCustomer.TabIndex = 9;
            // 
            // btnCustomerCheck
            // 
            this.btnCustomerCheck.BackColor = System.Drawing.Color.Wheat;
            this.btnCustomerCheck.Location = new System.Drawing.Point(13, 150);
            this.btnCustomerCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerCheck.Name = "btnCustomerCheck";
            this.btnCustomerCheck.Size = new System.Drawing.Size(197, 28);
            this.btnCustomerCheck.TabIndex = 4;
            this.btnCustomerCheck.Text = "Kiểm Tra Khách Hàng";
            this.btnCustomerCheck.UseVisualStyleBackColor = false;
            this.btnCustomerCheck.Click += new System.EventHandler(this.btnCustomerCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "SỐ ĐIỆN THOẠI KHÁCH HÀNG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN KHÁCH HÀNG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ BILL:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnDelProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 66);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDone);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.btnCalMoney);
            this.panel5.Controls.Add(this.btnDel);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txtTotalMoney);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(325, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(675, 66);
            this.panel5.TabIndex = 27;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Green;
            this.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDone.Location = new System.Drawing.Point(28, 40);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(309, 27);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "HOÀN TẤT HÓA ĐƠN";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "TỔNG SỐ TIỀN PHẢI TRẢ:";
            // 
            // btnCalMoney
            // 
            this.btnCalMoney.BackColor = System.Drawing.Color.Gold;
            this.btnCalMoney.Location = new System.Drawing.Point(151, 9);
            this.btnCalMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalMoney.Name = "btnCalMoney";
            this.btnCalMoney.Size = new System.Drawing.Size(137, 28);
            this.btnCalMoney.TabIndex = 26;
            this.btnCalMoney.Text = "Tính toán lại số tiền";
            this.btnCalMoney.UseVisualStyleBackColor = false;
            this.btnCalMoney.Click += new System.EventHandler(this.btnCalMoney_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkRed;
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(355, 40);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(309, 27);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "HỦY HÓA ĐƠN";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(636, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "vnđ";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Location = new System.Drawing.Point(494, 12);
            this.txtTotalMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(136, 22);
            this.txtTotalMoney.TabIndex = 23;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelProduct.Location = new System.Drawing.Point(3, 2);
            this.btnDelProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(316, 28);
            this.btnDelProduct.TabIndex = 26;
            this.btnDelProduct.Text = "XÓA SẢN PHẨM ĐÁNH DẤU";
            this.btnDelProduct.UseVisualStyleBackColor = false;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 633);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateBill";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CreateBill_Load);
            this.panelTable.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCustomerCheck;
        private System.Windows.Forms.Button voucherCheck;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReduction;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCalMoney;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.TextBox txtVouID;
        private System.Windows.Forms.ComboBox txtBillID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCanel;
    }
}