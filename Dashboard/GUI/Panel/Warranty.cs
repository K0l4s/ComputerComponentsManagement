using Dashboard.DAO;
using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI.Panel
{
    public partial class Warranty : Form
    {
        WarrantyDTO warranty = new WarrantyDTO(null,null,null,null,null,null,null);
        DataTable dta = null;
        public Warranty()
        {
            InitializeComponent();
            dta = WarrantyDAO.Instance.GetListStatus();
            cbStatus.DataSource = dta;
            cbStatus.DisplayMember = dta.Columns[1].ToString();
            cbStatus.ValueMember = dta.Columns[0].ToString();
            (dtgTable.Columns["warr_StatusID"] as DataGridViewComboBoxColumn).DataSource = dta;
            (dtgTable.Columns["warr_StatusID"] as DataGridViewComboBoxColumn).DisplayMember = dta.Columns[1].ToString();
            (dtgTable.Columns["warr_StatusID"] as DataGridViewComboBoxColumn).ValueMember = dta.Columns[0].ToString(); ;
        }
        private void Warranty_Load(object sender, EventArgs e)
        {
            warranty = new WarrantyDTO(null, null, null, null, null, null, null);
            pnTools.Visible = false;
            TableDefault();
        }
        private void TableDefault()
        {
            dta =WarrantyDAO.Instance.LoadTable(warranty);
            dtgTable.DataSource = dta;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            warranty = new WarrantyDTO(null, null, null, null, null, null, null);
            TableDefault();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtBillID.Text = null;
            txtDescript.Text = null;
            cbStatus.Text = null;
            txtProductID.Text = null;
            txtProductName.Text = null;
            txtQuantity.Text = null;
            txtWarrantyID.Text = null;
        }

        private void btnCloseTool_Click(object sender, EventArgs e)
        {
            pnTools.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnTools.Visible = true;

            txtWarrantyID.Enabled = true;
            txtProductID.Enabled = true;
            txtProductName.Enabled = false;
            cbStatus.Enabled = true;
            txtDescript.Enabled = false;
            txtQuantity.Enabled = true;
            txtBillID.Enabled = true;

            btnTools.Text = "Tìm kiếm";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnTools.Visible = true;

            txtWarrantyID.Enabled = true;
            txtProductID.Enabled = true;
            txtProductName.Enabled = false;
            cbStatus.Enabled = true;
            txtDescript.Enabled = true;
            txtQuantity.Enabled = true;
            txtBillID.Enabled = true;

            btnTools.Text = "Thêm";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnTools.Visible = true;

            txtWarrantyID.Enabled = true;
            txtProductID.Enabled = false;
            txtProductName.Enabled = false;
            cbStatus.Enabled = false;
            txtDescript.Enabled = false;
            txtQuantity.Enabled = false;
            txtBillID.Enabled = false;

            btnTools.Text = "Xóa";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnTools.Visible = true;

            txtWarrantyID.Enabled = true;
            txtProductID.Enabled = true;
            txtProductName.Enabled = false;
            cbStatus.Enabled = true;
            txtDescript.Enabled = true;
            txtQuantity.Enabled = true;
            txtBillID.Enabled = true;

            btnTools.Text = "Sửa";
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            if(btnTools.Text=="Tìm kiếm")
            {
                searchInfor();
            }    
            else if(btnTools.Text == "Thêm")
            {
                addInfor();
            }   
            else if(btnTools.Text == "Sửa")
            {
                updateInfor();
            }    
            else if(btnTools.Text == "Xóa")
            {
                deleteInfor();
            }    
            else
            {
                MessageBox.Show("Thao tác thất bại! Thử reset trang để thử lại sau!");
            }    
        }

        private void GetData()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtWarrantyID.Text))
                    warranty.warrantyID = txtWarrantyID.Text;
                if (!String.IsNullOrEmpty(txtProductID.Text))
                    warranty.productID = txtProductID.Text;
                if (!String.IsNullOrEmpty(txtProductName.Text))
                    warranty.productName = txtProductName.Text;
                if (!String.IsNullOrEmpty(txtQuantity.Text))
                    warranty.quantity = Int32.Parse(txtQuantity.Text);
                if (!String.IsNullOrEmpty(txtBillID.Text))
                    warranty.billID = txtBillID.Text;
                if (!String.IsNullOrEmpty(cbStatus.Text))
                    warranty.warr_statusID = Int32.Parse(cbStatus.SelectedValue.ToString());
                if (!String.IsNullOrEmpty(txtDescript.Text))
                    warranty.descript = txtDescript.Text;
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!");
            }
        }
        private void searchInfor()
        {
            GetData();
            dta = WarrantyDAO.Instance.LoadTable(warranty);
            dtgTable.DataSource = dta;
            warranty = new WarrantyDTO(null, null, null, null, null, null, null);
            btnClearData_Click(null,null);
        }
        private void addInfor()
        {
            GetData();
            string err = WarrantyDAO.Instance.AddWarranty(warranty);
            warranty = new WarrantyDTO(null, null, null, null, null, null, null);
            Warranty_Load(null, null);
            MessageBox.Show(err);
            btnClearData_Click(null, null);
        }
        private void deleteInfor()
        {
            GetData();
            string err = WarrantyDAO.Instance.deleteWarranty(warranty);
            warranty = new WarrantyDTO(null, null, null, null, null, null, null);
            Warranty_Load(null, null);
            MessageBox.Show(err);
            btnClearData_Click(null, null);
        }
        private void updateInfor()
        {
            GetData();
            string err = WarrantyDAO.Instance.updateWarranty(warranty);
            warranty = new WarrantyDTO(null, null, null, null, null, null, null);
            Warranty_Load(null, null);
            MessageBox.Show(err);
            btnClearData_Click(null, null);
        }

        private void dtgTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgTable.Rows[e.RowIndex];
                txtWarrantyID.Text = row.Cells["warrantyID"].Value.ToString();
                txtProductID.Text = row.Cells["productID"].Value.ToString();
                txtProductName.Text = row.Cells["productName"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtBillID.Text = row.Cells["billID"].Value.ToString();
                cbStatus.Text = row.Cells["warr_StatusID"].FormattedValue.ToString();
                txtDescript.Text = row.Cells["descript"].Value.ToString();
            }
        }
    }
}
