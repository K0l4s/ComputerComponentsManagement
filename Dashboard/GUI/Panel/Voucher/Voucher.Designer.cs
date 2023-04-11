namespace Dashboard.GUI.Panel.Voucher
{
    partial class Voucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voucher));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelTools = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseTool = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.txtNumberUsed = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReduction = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pCenter = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.voucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentReduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.pCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1059, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 570);
            this.panel2.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(0, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 50);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 50);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-327, -141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 SVNCintra", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "VOUCHER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 100);
            this.panel1.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(0, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Hiển Thị Tất Cả Voucher";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTools.Controls.Add(this.label11);
            this.panelTools.Controls.Add(this.btnClearData);
            this.panelTools.Controls.Add(this.label10);
            this.panelTools.Controls.Add(this.label9);
            this.panelTools.Controls.Add(this.label8);
            this.panelTools.Controls.Add(this.label7);
            this.panelTools.Controls.Add(this.txtYear);
            this.panelTools.Controls.Add(this.txtMonth);
            this.panelTools.Controls.Add(this.txtDay);
            this.panelTools.Controls.Add(this.label6);
            this.panelTools.Controls.Add(this.label5);
            this.panelTools.Controls.Add(this.label4);
            this.panelTools.Controls.Add(this.label3);
            this.panelTools.Controls.Add(this.label2);
            this.panelTools.Controls.Add(this.btnCloseTool);
            this.panelTools.Controls.Add(this.btnTools);
            this.panelTools.Controls.Add(this.txtNumberUsed);
            this.panelTools.Controls.Add(this.txtLimit);
            this.panelTools.Controls.Add(this.cbStatus);
            this.panelTools.Controls.Add(this.txtName);
            this.panelTools.Controls.Add(this.txtReduction);
            this.panelTools.Controls.Add(this.txtID);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTools.Location = new System.Drawing.Point(704, 100);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(355, 570);
            this.panelTools.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(307, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "%";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(176, 507);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(157, 51);
            this.btnClearData.TabIndex = 23;
            this.btnClearData.Text = "HOÀN TÁC DỮ LIỆU";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(249, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Đã dùng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(40, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giới hạn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(202, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(112, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "/";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(220, 286);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(112, 22);
            this.txtYear.TabIndex = 17;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(133, 286);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(67, 22);
            this.txtMonth.TabIndex = 16;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(39, 286);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(67, 22);
            this.txtDay.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(39, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "NGÀY HẾT HẠN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(39, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "TRẠNG THÁI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(39, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "GIẢM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "TÊN MÃ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            // 
            // btnCloseTool
            // 
            this.btnCloseTool.Location = new System.Drawing.Point(329, 0);
            this.btnCloseTool.Name = "btnCloseTool";
            this.btnCloseTool.Size = new System.Drawing.Size(25, 23);
            this.btnCloseTool.TabIndex = 9;
            this.btnCloseTool.Text = "X";
            this.btnCloseTool.UseVisualStyleBackColor = true;
            this.btnCloseTool.Click += new System.EventHandler(this.btnCloseTool_Click);
            // 
            // btnTools
            // 
            this.btnTools.Location = new System.Drawing.Point(39, 389);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(293, 85);
            this.btnTools.TabIndex = 8;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumberUsed
            // 
            this.txtNumberUsed.Location = new System.Drawing.Point(206, 342);
            this.txtNumberUsed.Name = "txtNumberUsed";
            this.txtNumberUsed.Size = new System.Drawing.Size(125, 22);
            this.txtNumberUsed.TabIndex = 7;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(39, 342);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(125, 22);
            this.txtLimit.TabIndex = 6;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Còn HSD",
            "Quá HSD"});
            this.cbStatus.Location = new System.Drawing.Point(39, 215);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(293, 24);
            this.cbStatus.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(39, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtReduction
            // 
            this.txtReduction.Location = new System.Drawing.Point(99, 154);
            this.txtReduction.Name = "txtReduction";
            this.txtReduction.Size = new System.Drawing.Size(202, 22);
            this.txtReduction.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 62);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(293, 22);
            this.txtID.TabIndex = 0;
            // 
            // pCenter
            // 
            this.pCenter.Controls.Add(this.dtgvTable);
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Location = new System.Drawing.Point(0, 100);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(704, 570);
            this.pCenter.TabIndex = 9;
            // 
            // dtgvTable
            // 
            this.dtgvTable.AllowUserToAddRows = false;
            this.dtgvTable.AllowUserToDeleteRows = false;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voucherID,
            this.expiryDate,
            this.voucherName,
            this.status,
            this.PercentReduction,
            this.limitNumber,
            this.numberUsed});
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.ReadOnly = true;
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(704, 570);
            this.dtgvTable.TabIndex = 1;
            this.dtgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTable_CellClick);
            // 
            // voucherID
            // 
            this.voucherID.DataPropertyName = "voucherID";
            this.voucherID.HeaderText = "voucherID";
            this.voucherID.MinimumWidth = 6;
            this.voucherID.Name = "voucherID";
            this.voucherID.ReadOnly = true;
            this.voucherID.Width = 125;
            // 
            // expiryDate
            // 
            this.expiryDate.DataPropertyName = "expiryDate";
            this.expiryDate.HeaderText = "expiryDate";
            this.expiryDate.MinimumWidth = 6;
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.ReadOnly = true;
            this.expiryDate.Width = 125;
            // 
            // voucherName
            // 
            this.voucherName.DataPropertyName = "Name Voucher";
            this.voucherName.HeaderText = "Name Voucher";
            this.voucherName.MinimumWidth = 6;
            this.voucherName.Name = "voucherName";
            this.voucherName.ReadOnly = true;
            this.voucherName.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "Name of Status";
            this.status.HeaderText = "Name of Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // PercentReduction
            // 
            this.PercentReduction.DataPropertyName = "Percent Reduction ";
            this.PercentReduction.HeaderText = "PercentReduction";
            this.PercentReduction.MinimumWidth = 6;
            this.PercentReduction.Name = "PercentReduction";
            this.PercentReduction.ReadOnly = true;
            this.PercentReduction.Width = 125;
            // 
            // limitNumber
            // 
            this.limitNumber.DataPropertyName = "limitNumber";
            this.limitNumber.HeaderText = "limitNumber";
            this.limitNumber.MinimumWidth = 6;
            this.limitNumber.Name = "limitNumber";
            this.limitNumber.ReadOnly = true;
            this.limitNumber.Width = 125;
            // 
            // numberUsed
            // 
            this.numberUsed.DataPropertyName = "numberUsed";
            this.numberUsed.HeaderText = "numberUsed";
            this.numberUsed.MinimumWidth = 6;
            this.numberUsed.Name = "numberUsed";
            this.numberUsed.ReadOnly = true;
            this.numberUsed.Width = 125;
            // 
            // Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 670);
            this.Controls.Add(this.pCenter);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Voucher";
            this.Text = "Voucher";
            this.Load += new System.EventHandler(this.Voucher_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.pCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.TextBox txtReduction;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtNumberUsed;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnCloseTool;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentReduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberUsed;
    }
}