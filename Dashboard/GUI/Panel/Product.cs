using Dashboard.DAO;
using Dashboard.DTO;
using Dashboard.GUI.Panel.Voucher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI.Panel
{
    public partial class Product : Form
    {
        DataTable dta = null;
        public Product()
        {
            InitializeComponent();
        }
        public void TableDefault()
        {
            ProductDTO product = new ProductDTO();
            dtgvTable.DataSource = ProductDAO.Instance.LoadTable(product);
            panelTools.Visible = false;

        }

        private void Product_Load(object sender, EventArgs e)
        {
            TableDefault();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TableDefault();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtBrand.Text = null;
            txtDescript.Text = null;
            txtID.Text = null;
            txtImport.Text = null;
            txtName.Text = null;
            txtQuantity.Text = null;
            txtSell.Text = null;
            txtType.Text = null;
        }

        private void btnCloseTool_Click(object sender, EventArgs e)
        {
            panelTools.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Tìm kiếm";
            panelTools.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Thêm";
            panelTools.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Xóa";
            panelTools.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Sửa";
            panelTools.Visible = true;
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            if(btnTools.Text == "Tìm kiếm")
            {
                searchInfo();
            }    
        }
        private void searchInfo()
        {
            ProductDTO product = new ProductDTO();
            if (!String.IsNullOrEmpty(txtID.Text))
                product.productID = txtID.Text;
            if (!String.IsNullOrEmpty(txtName.Text))
                product.productName = txtName.Text;
            if (!String.IsNullOrEmpty(txtID.Text))
                product.productID = txtID.Text;
            if (!String.IsNullOrEmpty(txtQuantity.Text))
                try
                {
                    product.quantity = Int32.Parse(txtQuantity.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                }
            if (!String.IsNullOrEmpty(txtType.Text))
                product.typeName = txtType.Text;
            if (!String.IsNullOrEmpty(txtBrand.Text))
                product.brandName = txtBrand.Text;
            if (!String.IsNullOrEmpty(txtImport.Text))
                try
                {
                    product.importPrice = Int32.Parse(txtImport.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                }
            if (!String.IsNullOrEmpty(txtSell.Text))
                try
                {
                    product.sellPrice = Int32.Parse(txtSell.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                }
            if (!String.IsNullOrEmpty(txtDescript.Text))
                product.descript = txtDescript.Text;
            dta = ProductDAO.Instance.LoadTable(product);
            dtgvTable.DataSource = dta;
        }    

    }
}
