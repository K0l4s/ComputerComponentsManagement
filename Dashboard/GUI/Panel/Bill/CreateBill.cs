using Dashboard.DAO;
using Dashboard.DTO;
using Dashboard.GUI.Panel;
using Dashboard.GUI.Panel.Bill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI
{
    public partial class CreateBill : Form
    {
        List<string> billIDList = new List<string>();
        List<string> checkProduct = new List<string>();
        List <ProductInBillDTO> productInBill = new List<ProductInBillDTO>();
        public CreateBill()
        {
            InitializeComponent();
            panelAdd.Width = panelTable.Width;
        }
        private void CreateBill_Load(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = false;
            txtAddress.Enabled = false;
            txtCustomer.Enabled = false;
            btnCustomerCheck.Enabled = true;
            btnCanel.Visible = false;
            btnDel_Click(null, null);
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            addProduct();
            
        }
        private void addProduct()
        {
            List<ProductInBillDTO> product = new List<ProductInBillDTO>();
            SearchProductForBill search = new SearchProductForBill();
            search.ShowDialog();
            product = search.Result;
            if (product != null)
                foreach (ProductInBillDTO item in product)
                {
                    foreach (string secondItem in checkProduct)
                    {
                        if (secondItem == item.productID)
                        {
                            MessageBox.Show("Đã lựa chọn sản phẩm! Xin vui lòng thử lại sau!");
                            return;
                        }
                    }
                    checkProduct.Add(item.productID);
                    productInBill.Add(item);
                    ProductDTO adding = new ProductDTO();
                    adding.productID = item.productID;
                    DataTable dt = ProductDAO.Instance.LoadTable(adding);
                    ProductControl productControl = new ProductControl();
                    productControl.productID = item.productID;
                    productControl.productName = item.productName;
                    productControl.Price = item.price;
                    productControl.ImageFilePath = item.Image;
                    productControl.Quantity = item.quantity;
                    flowLayoutPanel1.Controls.Add(productControl);
                }
        }
        private void btnCustomerCheck_Click(object sender, EventArgs e)
        {
            DataTable dt = CustomerDAO.Instance.LoadTable(txtPhoneNo.Text);
            if (dt.Columns.Count > 0)
            {
                DataColumn firstColumn = dt.Columns[0];
                DataColumn secondColumn = dt.Columns[2];
                if (firstColumn != null)
                {
                    int rowIndex = 0;
                    if (dt.Rows.Count > 0)
                    {
                        DataRow firstRow = dt.Rows[rowIndex];
                        object Name = firstRow[firstColumn.ColumnName];
                        object addr = firstRow[secondColumn.ColumnName];
                        if (Name != null)
                        {
                            txtCustomer.Text = Name.ToString();
                        }
                        if (addr != null)
                        {
                            txtAddress.Text = addr.ToString();
                            MessageBox.Show("Khách hàng đã đăng ký thành viên!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không tồn tại!");
                        btnAddCustomer.Enabled = true;
                        txtAddress.Enabled = true;
                        txtCustomer.Enabled = true;
                        btnCustomerCheck.Enabled = false;
                        btnCanel.Visible = true;

                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không tồn tại!");
                    btnAddCustomer.Enabled = true;
                    txtAddress.Enabled = true;
                    txtCustomer.Enabled = true;
                    btnCustomerCheck.Enabled = false;
                    btnCanel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không tồn tại!");
                btnAddCustomer.Enabled = true;
                txtAddress.Enabled = true;
                txtCustomer.Enabled = true;
                btnCustomerCheck.Enabled = false;
                btnCanel.Visible = true;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = null, phoneNo = null, add = null;
            if (!String.IsNullOrEmpty(txtCustomer.Text))
            {
                name = txtCustomer.Text;
            }
            if (!String.IsNullOrEmpty(txtAddress.Text))
                add = txtAddress.Text;
            if (!String.IsNullOrEmpty(txtPhoneNo.Text))
            {
                phoneNo = txtPhoneNo.Text;
            }
            string err = CustomerDAO.Instance.AddCustomer(txtPhoneNo.Text, txtCustomer.Text, txtAddress.Text);
            MessageBox.Show(err);
            btnAddCustomer.Enabled = false;
            txtAddress.Enabled = false;
            txtCustomer.Enabled = false;
            btnCustomerCheck.Enabled = true;
        }
        private void calculateMoney()
        {
            float totalMoney = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (flowLayoutPanel1.Controls.Count > 0 && control is ProductControl)
                {
                    ProductControl productControl = (ProductControl)control;
                    totalMoney += productControl.TotalMoney;
                }
            }
            try
            {
                if (!String.IsNullOrEmpty(txtReduction.Text))
                    totalMoney -= totalMoney * Int32.Parse(txtReduction.Text)/100;
            }
            catch(Exception)
            { }
            txtTotalMoney.Text = totalMoney.ToString();
        }
        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            calculateMoney();
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            calculateMoney();
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            calculateMoney();
        }

        private void btnCalMoney_Click(object sender, EventArgs e)
        {
            calculateMoney();
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            while (flowLayoutPanel1.Controls.OfType<ProductControl>().Any(c => c.myCheckBox.Checked))
            {
                ProductControl productControl = flowLayoutPanel1.Controls.OfType<ProductControl>().First(c => c.myCheckBox.Checked);
                flowLayoutPanel1.Controls.Remove(productControl);
                checkProduct.Remove(productControl.productID);
                productInBill.RemoveAll(p => p.productID == productControl.productID);
            }

        }

        private void voucherCheck_Click(object sender, EventArgs e)
        {
            DataTable dt = VoucherDAO.Instance.LoadTable(txtVouID.Text);
            if (dt.Columns.Count > 0)
            {
                DataColumn firstColumn = dt.Columns[2];
                if (firstColumn != null)
                {
                    int rowIndex = 0;
                    if (dt.Rows.Count > 0)
                    {
                        DataRow firstRow = dt.Rows[rowIndex];
                        object Name = firstRow[firstColumn.ColumnName];
                        if (Name != null)
                        {
                            txtReduction.Text = Name.ToString();
                            calculateMoney();
                            MessageBox.Show("Đủ điều kiện sử dụng voucher!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại Voucher!");
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại Voucher!");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại Voucher!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            txtAddress.Text = null;
            txtPhoneNo.Text = null;
            txtReduction.Text = null;
            txtTotalMoney.Text = "0";
            txtVouID.Text = null;
            txtCustomer.Text = null;
            txtDay.Text = today.Day.ToString();
            txtMonth.Text = today.Month.ToString();
            txtYear.Text = today.Year.ToString();
            txtEmployeeID.Text = EmployeeDAO.userLogin.ToString();
            Random random = new Random();
            txtBillID.Text = today.Year.ToString() + today.Month + today.Day + today.Hour + today.Minute + today.Minute +random.Next(1111,9999);
          
            checkProduct.Clear();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(this.btnAddProduct);

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string billID = null, phoneNumber = null, voucherID = null;
            DateTime? billExportTime=null;
            int? employeeID=null;
            if(!String.IsNullOrEmpty(txtBillID.Text))
                billID = txtBillID.Text;
            if (!String.IsNullOrEmpty(txtPhoneNo.Text))
                phoneNumber = txtPhoneNo.Text;
            billExportTime = DateTime.Now;
            try
            {
                if (!String.IsNullOrEmpty(txtEmployeeID.Text))
                    employeeID = Int32.Parse(txtEmployeeID.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Tạo bill thất bại do chưa nhập nhân viên!");
            }
            if (productInBill.Count<1)
            {
                MessageBox.Show("Tạo bill thất bại do bạn chưa chọn sản phẩm!");
                return;
            }
            string err = BillDAO.Instance.addProduct( billID, 1, phoneNumber, billExportTime);
            foreach(ProductInBillDTO item in productInBill)
            {
                err = BillDAO.Instance.addItem(billID, item.productID, item.quantity);
            }
            if (!String.IsNullOrEmpty(txtVouID.Text))
                err = BillDAO.Instance.addVoucher(billID, txtVouID.Text);
            btnDel_Click(null, null);
            if (err==null)
                err = "Tạo bill mới thành công!";
            MessageBox.Show(err);
            btnDelProduct_Click(null, null);
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = false;
            btnCustomerCheck.Enabled = true;
            btnCanel.Visible = false;
        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            calculateMoney();
        }
    }
}
