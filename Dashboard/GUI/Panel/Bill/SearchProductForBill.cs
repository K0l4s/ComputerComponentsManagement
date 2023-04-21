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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dashboard.GUI.Panel.Bill
{
    public partial class SearchProductForBill : Form
    {
        public SearchProductForBill()
        {
            InitializeComponent();
        }

        private void SearchProductForBill_Load(object sender, EventArgs e)
        {
            ProductDTO product = new ProductDTO();
            DataTable dt = ProductDAO.Instance.LoadTable(product);
            int count = 0;
                foreach (DataRow dr in dt.Rows)
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

        private void flowLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            ProductControl product = (ProductControl)sender;

        }
    }
}
