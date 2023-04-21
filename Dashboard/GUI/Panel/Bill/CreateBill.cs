using Dashboard.DAO;
using Dashboard.DTO;
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
        public CreateBill()
        {
            InitializeComponent();
            panelAdd.Width = panelTable.Width;
            AddProduct();
        }
        public void AddProduct()
        {
            ProductDTO product = new ProductDTO();
            DataTable dt = ProductDAO.Instance.LoadTable(product);
            int count = 0;
            for(int i=0;i<15;i++)
                foreach(DataRow dr in dt.Rows)
                {
                    ProductControl productControl = new ProductControl();
                    productControl.productID = dr["productID"].ToString();
                    productControl.productName = dr["productName"].ToString();
                    productControl.Price = float.Parse(dr["sellPrice"].ToString());
                    productControl.ImageFilePath = dr["productImageURL"].ToString();
                    productControl.Quantity = 1;
                    count++;
                    flowLayoutPanel1.Controls.Add(productControl);
                }


        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            SearchProductForBill search = new SearchProductForBill();
            search.ShowDialog();
            List <ProductInBillDTO> product = new List<ProductInBillDTO>();

        }
    }
}
