namespace Dashboard.GUI.Panel.Voucher
{
    partial class VoucherTable
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
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.voucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentReduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voucherID,
            this.voucherName,
            this.PercentReduction,
            this.status,
            this.limitNumber,
            this.numberUsed});
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(946, 610);
            this.dtgvTable.TabIndex = 0;
            // 
            // voucherID
            // 
            this.voucherID.HeaderText = "voucherID";
            this.voucherID.MinimumWidth = 6;
            this.voucherID.Name = "voucherID";
            this.voucherID.Width = 125;
            // 
            // voucherName
            // 
            this.voucherName.HeaderText = "Name Voucher";
            this.voucherName.MinimumWidth = 6;
            this.voucherName.Name = "voucherName";
            this.voucherName.Width = 125;
            // 
            // PercentReduction
            // 
            this.PercentReduction.HeaderText = "Percent Reduction";
            this.PercentReduction.MinimumWidth = 6;
            this.PercentReduction.Name = "PercentReduction";
            this.PercentReduction.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Name of Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // limitNumber
            // 
            this.limitNumber.HeaderText = "limitNumber";
            this.limitNumber.MinimumWidth = 6;
            this.limitNumber.Name = "limitNumber";
            this.limitNumber.Width = 125;
            // 
            // numberUsed
            // 
            this.numberUsed.HeaderText = "numberUsed";
            this.numberUsed.MinimumWidth = 6;
            this.numberUsed.Name = "numberUsed";
            this.numberUsed.Width = 125;
            // 
            // VoucherTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 610);
            this.Controls.Add(this.dtgvTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoucherTable";
            this.Text = "VoucherTable";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentReduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberUsed;
    }
}