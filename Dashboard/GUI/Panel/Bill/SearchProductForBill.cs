using Dashboard.DAO;
using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<ProductInBillDTO> listProduct = new List<ProductInBillDTO>();
        private void SearchProductForBill_Load(object sender, EventArgs e)
        {
            
            
            ProductDTO product = new ProductDTO();
            DataTable dt = ProductDAO.Instance.LoadTable(product);
            foreach (DataRow dr in dt.Rows)
            {
                ProductControl productControl = new ProductControl();
                productControl.productID = dr["productID"].ToString();
                productControl.productName = dr["productName"].ToString();
                productControl.Price = float.Parse(dr["sellPrice"].ToString());
                
                Image img = null;
                try
                {
                    byte[] imgBytes = null;
                    imgBytes = (byte[])dr["productImageURL"];
                    MemoryStream ms = new MemoryStream(imgBytes);
                    img = Image.FromStream(ms);
                }
                catch (Exception)
                { }
                productControl.ImageFilePath = img;
                productControl.Quantity = 1;
                flowLayoutPanel1.Controls.Add(productControl);
            }
        }
        ProductControl product = new ProductControl();
        public List<ProductInBillDTO> Result
        {
            get { return listProduct; }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            foreach(ProductControl item in flowLayoutPanel1.Controls)
            { 
                if(item.myCheckBox.Checked == true)
                {
                    listProduct.Add(new ProductInBillDTO(item.productID, item.productName, item.Price, item.Quantity, item.TotalMoney, item.ImageFilePath));
                }    
            }    
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            listProduct = null;
            this.Close();
        }
    }
}
