namespace Dashboard.GUI.Panel
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panelTools = new System.Windows.Forms.Panel();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnCloseTool = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.productImageURL = new System.Windows.Forms.DataGridViewImageColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1262, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 917);
            this.panel2.TabIndex = 9;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 100);
            this.panel1.TabIndex = 8;
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
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SẢN PHẨM";
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
            this.dtgvBill.Size = new System.Drawing.Size(1262, 917);
            this.dtgvBill.TabIndex = 0;
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTools.Controls.Add(this.txtDescript);
            this.panelTools.Controls.Add(this.label9);
            this.panelTools.Controls.Add(this.txtSell);
            this.panelTools.Controls.Add(this.label8);
            this.panelTools.Controls.Add(this.txtImport);
            this.panelTools.Controls.Add(this.label7);
            this.panelTools.Controls.Add(this.txtBrand);
            this.panelTools.Controls.Add(this.label6);
            this.panelTools.Controls.Add(this.txtType);
            this.panelTools.Controls.Add(this.label5);
            this.panelTools.Controls.Add(this.txtQuantity);
            this.panelTools.Controls.Add(this.label4);
            this.panelTools.Controls.Add(this.txtName);
            this.panelTools.Controls.Add(this.label3);
            this.panelTools.Controls.Add(this.txtID);
            this.panelTools.Controls.Add(this.label2);
            this.panelTools.Controls.Add(this.picImage);
            this.panelTools.Controls.Add(this.btnRefresh);
            this.panelTools.Controls.Add(this.btnClearData);
            this.panelTools.Controls.Add(this.btnCloseTool);
            this.panelTools.Controls.Add(this.btnTools);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTools.Location = new System.Drawing.Point(904, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(358, 917);
            this.panelTools.TabIndex = 10;
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(18, 307);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(334, 22);
            this.txtDescript.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(15, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "MÔ TẢ SẢN PHẨM:";
            // 
            // txtSell
            // 
            this.txtSell.Location = new System.Drawing.Point(197, 255);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(155, 22);
            this.txtSell.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(194, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "GIÁ BÁN:";
            // 
            // txtImport
            // 
            this.txtImport.Location = new System.Drawing.Point(18, 255);
            this.txtImport.Name = "txtImport";
            this.txtImport.Size = new System.Drawing.Size(173, 22);
            this.txtImport.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(15, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "GIÁ NHẬP:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(198, 205);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(154, 22);
            this.txtBrand.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(195, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "NHÃN HÀNG:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(18, 205);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(173, 22);
            this.txtType.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "PHÂN LOẠI:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(18, 158);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(173, 22);
            this.txtQuantity.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "SỐ LƯỢNG:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 22);
            this.txtName.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "TÊN SẢN PHẨM:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 22);
            this.txtID.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "MÃ SẢN PHẨM:";
            // 
            // picImage
            // 
            this.picImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picImage.ErrorImage")));
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(218, 65);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(114, 115);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 24;
            this.picImage.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Hiển Thị Tất Cả Voucher";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvTable);
            this.panel3.Controls.Add(this.panelTools);
            this.panel3.Controls.Add(this.dtgvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 917);
            this.panel3.TabIndex = 10;
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productImageURL,
            this.productID,
            this.productName,
            this.quantity,
            this.typeName,
            this.brandName,
            this.importPrice,
            this.sellPrice,
            this.descript});
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(904, 917);
            this.dtgvTable.TabIndex = 11;
            // 
            // productImageURL
            // 
            this.productImageURL.DataPropertyName = "productImageURL";
            this.productImageURL.HeaderText = "productImageURL";
            this.productImageURL.Image = ((System.Drawing.Image)(resources.GetObject("productImageURL.Image")));
            this.productImageURL.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.productImageURL.MinimumWidth = 6;
            this.productImageURL.Name = "productImageURL";
            this.productImageURL.Width = 125;
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
            this.quantity.HeaderText = "Số Lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "typeName";
            this.typeName.HeaderText = "Phân Loại";
            this.typeName.MinimumWidth = 6;
            this.typeName.Name = "typeName";
            this.typeName.Width = 125;
            // 
            // brandName
            // 
            this.brandName.DataPropertyName = "brandName";
            this.brandName.HeaderText = "Nhãn Hàng";
            this.brandName.MinimumWidth = 6;
            this.brandName.Name = "brandName";
            this.brandName.Width = 125;
            // 
            // importPrice
            // 
            this.importPrice.DataPropertyName = "importPrice";
            this.importPrice.HeaderText = "Giá Nhập";
            this.importPrice.MinimumWidth = 6;
            this.importPrice.Name = "importPrice";
            this.importPrice.Width = 125;
            // 
            // sellPrice
            // 
            this.sellPrice.DataPropertyName = "sellPrice";
            this.sellPrice.HeaderText = "Giá Bán";
            this.sellPrice.MinimumWidth = 6;
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Width = 125;
            // 
            // descript
            // 
            this.descript.DataPropertyName = "descript";
            this.descript.HeaderText = "Mô Tả";
            this.descript.MinimumWidth = 6;
            this.descript.Name = "descript";
            this.descript.Width = 125;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 1017);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnCloseTool;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewImageColumn productImageURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn importPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn descript;
    }
}