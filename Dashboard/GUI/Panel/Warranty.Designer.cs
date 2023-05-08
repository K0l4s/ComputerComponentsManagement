namespace Dashboard.GUI.Panel
{
    partial class Warranty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warranty));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnTools = new System.Windows.Forms.Panel();
            this.btnCloseTool = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtWarrantyID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgTable = new System.Windows.Forms.DataGridView();
            this.warrantyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warr_StatusID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnTools.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 58);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 23);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Hiển thị tất cả";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(940, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 579);
            this.panel2.TabIndex = 1;
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
            this.btnUpdate.Size = new System.Drawing.Size(50, 50);
            this.btnUpdate.TabIndex = 20;
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
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 19;
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
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 18;
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
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.btnCloseTool);
            this.pnTools.Controls.Add(this.btnClearData);
            this.pnTools.Controls.Add(this.btnTools);
            this.pnTools.Controls.Add(this.label7);
            this.pnTools.Controls.Add(this.label6);
            this.pnTools.Controls.Add(this.label5);
            this.pnTools.Controls.Add(this.label4);
            this.pnTools.Controls.Add(this.txtQuantity);
            this.pnTools.Controls.Add(this.label3);
            this.pnTools.Controls.Add(this.label2);
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Controls.Add(this.txtDescript);
            this.pnTools.Controls.Add(this.cbStatus);
            this.pnTools.Controls.Add(this.txtBillID);
            this.pnTools.Controls.Add(this.txtProductName);
            this.pnTools.Controls.Add(this.txtProductID);
            this.pnTools.Controls.Add(this.txtWarrantyID);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTools.Location = new System.Drawing.Point(710, 100);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(230, 579);
            this.pnTools.TabIndex = 3;
            // 
            // btnCloseTool
            // 
            this.btnCloseTool.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseTool.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseTool.Location = new System.Drawing.Point(198, 6);
            this.btnCloseTool.Name = "btnCloseTool";
            this.btnCloseTool.Size = new System.Drawing.Size(25, 23);
            this.btnCloseTool.TabIndex = 33;
            this.btnCloseTool.Text = "X";
            this.btnCloseTool.UseVisualStyleBackColor = false;
            this.btnCloseTool.Click += new System.EventHandler(this.btnCloseTool_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(45, 531);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(150, 23);
            this.btnClearData.TabIndex = 13;
            this.btnClearData.Text = "Hoàn tác dữ liệu";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnTools
            // 
            this.btnTools.Location = new System.Drawing.Point(45, 469);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(147, 44);
            this.btnTools.TabIndex = 12;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ghi Chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trạng Thái Bảo Hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Lượng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(42, 224);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 22);
            this.txtQuantity.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Bảo Hành";
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(42, 362);
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(150, 77);
            this.txtDescript.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(42, 315);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 24);
            this.cbStatus.TabIndex = 4;
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(42, 267);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(150, 22);
            this.txtBillID.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(42, 182);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(42, 135);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(150, 22);
            this.txtProductID.TabIndex = 1;
            // 
            // txtWarrantyID
            // 
            this.txtWarrantyID.Location = new System.Drawing.Point(42, 88);
            this.txtWarrantyID.Name = "txtWarrantyID";
            this.txtWarrantyID.Size = new System.Drawing.Size(150, 22);
            this.txtWarrantyID.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 579);
            this.panel3.TabIndex = 4;
            // 
            // dtgTable
            // 
            this.dtgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warrantyID,
            this.productID,
            this.productName,
            this.quantity,
            this.billID,
            this.warr_StatusID,
            this.descript});
            this.dtgTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTable.Location = new System.Drawing.Point(0, 0);
            this.dtgTable.Name = "dtgTable";
            this.dtgTable.RowHeadersWidth = 51;
            this.dtgTable.RowTemplate.Height = 24;
            this.dtgTable.Size = new System.Drawing.Size(710, 579);
            this.dtgTable.TabIndex = 3;
            this.dtgTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTable_CellClick);
            // 
            // warrantyID
            // 
            this.warrantyID.DataPropertyName = "warrantyID";
            this.warrantyID.HeaderText = "Mã Bảo Hành";
            this.warrantyID.MinimumWidth = 6;
            this.warrantyID.Name = "warrantyID";
            this.warrantyID.Width = 125;
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "Mã Sản Phẩm";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.Width = 125;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Tên Sản Phẩm";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 125;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Số lượng bảo hành";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // billID
            // 
            this.billID.DataPropertyName = "billID";
            this.billID.HeaderText = "Mã Hóa Đơn";
            this.billID.MinimumWidth = 6;
            this.billID.Name = "billID";
            this.billID.Width = 125;
            // 
            // warr_StatusID
            // 
            this.warr_StatusID.DataPropertyName = "warr_StatusID";
            this.warr_StatusID.HeaderText = "Trạng Thái Bảo Hành";
            this.warr_StatusID.MinimumWidth = 6;
            this.warr_StatusID.Name = "warr_StatusID";
            this.warr_StatusID.Width = 125;
            // 
            // descript
            // 
            this.descript.DataPropertyName = "descript";
            this.descript.HeaderText = "Ghi chú";
            this.descript.MinimumWidth = 6;
            this.descript.Name = "descript";
            this.descript.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descript.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descript.Width = 125;
            // 
            // Warranty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnTools);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Warranty";
            this.Text = "Warranty";
            this.Load += new System.EventHandler(this.Warranty_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgTable;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtWarrantyID;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCloseTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn billID;
        private System.Windows.Forms.DataGridViewComboBoxColumn warr_StatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descript;
    }
}