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
            ProductDAO.Instance.LoadComboBoxType(cbType);
            ProductDAO.Instance.LoadComboBoxBrand(cbBrand);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TableDefault();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            cbBrand.Text = null;
            txtDescript.Text = null;
            txtID.Text = null;
            txtImport.Text = null;
            txtName.Text = null;
            txtQuantity.Text = null;
            txtSell.Text = null;
            cbType.Text = null;
        }

        private void btnCloseTool_Click(object sender, EventArgs e)
        {
            panelTools.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Tìm kiếm";
            panelTools.Visible = true;
            btnUploadPhoto.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Thêm";
            panelTools.Visible = true;
            btnUploadPhoto.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Xóa";
            panelTools.Visible = true;
            btnUploadPhoto.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Sửa";
            panelTools.Visible = true;
            btnUploadPhoto.Enabled = true;
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            if(btnTools.Text == "Tìm kiếm")
            {
                searchInfo();
            } 
            else if(btnTools.Text == "Thêm")
            {
                addInfo();
            }
            else if (btnTools.Text == "Xóa")
            {
                deleteInfo();
            }
            else if (btnTools.Text == "Sửa")
            {
                updateInfo();
            }
        }
        private void getInfo(ProductDTO product)
        {
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
            if (!String.IsNullOrEmpty(cbType.Text))
            {
                product.typeName = cbType.Text;
                product.typeID = cbType.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(cbBrand.Text))
            {
                product.brandName = cbBrand.Text;
                product.brandID = cbBrand.SelectedValue.ToString();
            }
            if (!String.IsNullOrEmpty(txtImport.Text))
                try
                {
                    product.importPrice = float.Parse(txtImport.Text);
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
            MemoryStream ms = new MemoryStream();
            picImage.Image.Save(ms, picImage.Image.RawFormat);
            byte[] img = ms.ToArray();
            product.productImageURL = img;
        }
        private void searchInfo()
        {
            ProductDTO product = new ProductDTO();
            getInfo(product);
            dta = ProductDAO.Instance.LoadTable(product);
            dtgvTable.DataSource = dta;
        }    
        private void addInfo()
        {
            string err = null;
            ProductDTO product = new ProductDTO();
            getInfo(product);
            MessageBox.Show(product.brandID);
            err = ProductDAO.Instance.AddProduct(product);
            TableDefault();
            MessageBox.Show(err);
        }
        private void deleteInfo()
        {
            string err = null;
            ProductDTO product = new ProductDTO();
            getInfo(product);
            err = ProductDAO.Instance.DeleteProduct(product);
            TableDefault();
            MessageBox.Show(err);
        }
        private void updateInfo()
        {
            string err = null;
            ProductDTO product = new ProductDTO();
            getInfo(product);
            err = ProductDAO.Instance.UpdateProduct(product);
            TableDefault();
            MessageBox.Show(err);
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = new Bitmap(openFileDialog.FileName);
                    MessageBox.Show("Upload ảnh thành công!");
                }
                else
                {
                    MessageBox.Show("Upload ảnh thất bại! vui lòng thử lại!");
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra rồi! \nNỘI DUNG LỖI: " + ex.Message);
            }
        }

        private void dtgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//Để tránh lấy tên của cột
            {
                DataGridViewRow row = this.dtgvTable.Rows[e.RowIndex];
                string productID = row.Cells["productID"].Value.ToString();
                string productName = row.Cells["productName"].Value.ToString();
                string quantity = row.Cells["quantity"].Value.ToString();
                string typeName = row.Cells["typeName"].Value.ToString();
                string brandName = row.Cells["brandName"].Value.ToString();
                string importPrice = row.Cells["importPrice"].Value.ToString();
                string sellPrice = row.Cells["sellPrice"].Value.ToString();
                string descript = row.Cells["descript"].Value.ToString();
                byte[] imgBytes = null;
                try
                {
                    imgBytes = (byte[])row.Cells["productImageURL"].Value;
                    MemoryStream ms = new MemoryStream(imgBytes);
                    picImage.Image = Image.FromStream(ms);
                }
                catch(Exception)
                { }
                txtID.Text = productID;
                txtName.Text = productName;
                txtQuantity.Text = quantity;
                cbType.Text = typeName;
                cbBrand.Text = brandName;
                txtImport.Text = importPrice;
                txtSell.Text = sellPrice;
                txtDescript.Text = descript;
            }
            
        }
        
    }
}
