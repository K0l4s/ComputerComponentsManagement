namespace Dashboard.GUI.Panel.Account
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCus_Add = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseTool = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 579);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "SẢN PHẨM";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-327, -141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1065, 100);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1020, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 479);
            this.panel2.TabIndex = 15;
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
            this.btnUpdate.Size = new System.Drawing.Size(45, 50);
            this.btnUpdate.TabIndex = 16;
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
            this.btnDelete.Size = new System.Drawing.Size(45, 50);
            this.btnDelete.TabIndex = 15;
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
            this.btnAdd.Size = new System.Drawing.Size(45, 50);
            this.btnAdd.TabIndex = 14;
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
            this.btnSearch.Size = new System.Drawing.Size(45, 50);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTools.Controls.Add(this.btnClear);
            this.panelTools.Controls.Add(this.label4);
            this.panelTools.Controls.Add(this.txtCus_Add);
            this.panelTools.Controls.Add(this.btnRefresh);
            this.panelTools.Controls.Add(this.label3);
            this.panelTools.Controls.Add(this.label2);
            this.panelTools.Controls.Add(this.btnCloseTool);
            this.panelTools.Controls.Add(this.btnTools);
            this.panelTools.Controls.Add(this.txtFullName);
            this.panelTools.Controls.Add(this.txtPhoneNo);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTools.Location = new System.Drawing.Point(690, 100);
            this.panelTools.Margin = new System.Windows.Forms.Padding(2);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(330, 479);
            this.panelTools.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(77, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 44);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Hoàn tác dữ liệu";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(53, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "Customer\'Address";
            // 
            // txtCus_Add
            // 
            this.txtCus_Add.Location = new System.Drawing.Point(77, 284);
            this.txtCus_Add.Name = "txtCus_Add";
            this.txtCus_Add.Size = new System.Drawing.Size(187, 22);
            this.txtCus_Add.TabIndex = 46;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(24, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 23);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Hiển Thị Tất Cả Voucher";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(53, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(53, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Phone Number";
            // 
            // btnCloseTool
            // 
            this.btnCloseTool.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseTool.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseTool.Location = new System.Drawing.Point(276, 38);
            this.btnCloseTool.Name = "btnCloseTool";
            this.btnCloseTool.Size = new System.Drawing.Size(25, 23);
            this.btnCloseTool.TabIndex = 32;
            this.btnCloseTool.Text = "X";
            this.btnCloseTool.UseVisualStyleBackColor = false;
            this.btnCloseTool.Click += new System.EventHandler(this.btnCloseTool_Click);
            // 
            // btnTools
            // 
            this.btnTools.Location = new System.Drawing.Point(77, 347);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(186, 44);
            this.btnTools.TabIndex = 31;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(82, 188);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(187, 22);
            this.txtFullName.TabIndex = 27;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(77, 95);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(187, 22);
            this.txtPhoneNo.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvTable);
            this.panel3.Controls.Add(this.dtgvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 479);
            this.panel3.TabIndex = 17;
            // 
            // dtgvTable
            // 
            this.dtgvTable.AllowUserToAddRows = false;
            this.dtgvTable.AllowUserToDeleteRows = false;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumber,
            this.fullName,
            this.cus_address});
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.ReadOnly = true;
            this.dtgvTable.RowHeadersWidth = 82;
            this.dtgvTable.RowTemplate.Height = 33;
            this.dtgvTable.Size = new System.Drawing.Size(690, 479);
            this.dtgvTable.TabIndex = 4;
            this.dtgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTable__CellClick);
            // 
            // dtgvBill
            // 
            this.dtgvBill.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(690, 479);
            this.dtgvBill.TabIndex = 0;
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "Number Phone";
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Width = 125;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "Full Name";
            this.fullName.HeaderText = "Full Name";
            this.fullName.MinimumWidth = 10;
            this.fullName.Name = "fullName";
            this.fullName.Width = 200;
            // 
            // cus_address
            // 
            this.cus_address.DataPropertyName = "Address";
            this.cus_address.HeaderText = "Custome\'s Address";
            this.cus_address.MinimumWidth = 10;
            this.cus_address.Name = "cus_address";
            this.cus_address.Width = 200;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 579);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCus_Add;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseTool;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_address;
        private System.Windows.Forms.DataGridView dtgvBill;
    }
}