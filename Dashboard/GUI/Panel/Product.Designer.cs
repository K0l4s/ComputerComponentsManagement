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
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnCloseTool = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelTools = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panelTools.SuspendLayout();
            this.SuspendLayout();
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
            this.dtgvBill.Size = new System.Drawing.Size(959, 512);
            this.dtgvBill.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelTools);
            this.panel3.Controls.Add(this.dtgvTable);
            this.panel3.Controls.Add(this.dtgvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 512);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(959, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 512);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 100);
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
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(959, 512);
            this.dtgvTable.TabIndex = 1;
            // 
            // btnTools
            // 
            this.btnTools.Location = new System.Drawing.Point(39, 389);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(293, 85);
            this.btnTools.TabIndex = 8;
            this.btnTools.UseVisualStyleBackColor = true;
            // 
            // btnCloseTool
            // 
            this.btnCloseTool.Location = new System.Drawing.Point(329, 0);
            this.btnCloseTool.Name = "btnCloseTool";
            this.btnCloseTool.Size = new System.Drawing.Size(25, 23);
            this.btnCloseTool.TabIndex = 9;
            this.btnCloseTool.Text = "X";
            this.btnCloseTool.UseVisualStyleBackColor = true;
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(176, 507);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(157, 51);
            this.btnClearData.TabIndex = 23;
            this.btnClearData.Text = "HOÀN TÁC DỮ LIỆU";
            this.btnClearData.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Hiển Thị Tất Cả Voucher";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTools.Controls.Add(this.btnRefresh);
            this.panelTools.Controls.Add(this.btnClearData);
            this.panelTools.Controls.Add(this.btnCloseTool);
            this.panelTools.Controls.Add(this.btnTools);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTools.Location = new System.Drawing.Point(601, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(358, 512);
            this.panelTools.TabIndex = 9;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnCloseTool;
        private System.Windows.Forms.Button btnTools;
    }
}