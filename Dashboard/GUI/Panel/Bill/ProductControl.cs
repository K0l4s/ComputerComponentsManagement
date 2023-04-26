using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI.Panel.Bill
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }
         public string productID
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }
        public string productName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public float Price
        {
            get { return float.Parse(txtPrice.Text); }
            set { txtPrice.Text =  value.ToString(); }
        }
        public int Quantity
        {
            get { return int.Parse(txtQuan.Text); }
            set { txtQuan.Text = value.ToString(); }
        }
        public float TotalMoney
        {
            get { return float.Parse(txtMoney.Text); }
            set { txtMoney.Text = value.ToString(); }
        }
        public string ImageFilePath
        {
            get { return picImage.ImageLocation; }
            set { picImage.ImageLocation = value; }
        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Quantity < 1)
                    txtQuan.Text = "1";
                if (txtQuan.Text != null)
                    txtMoney.Text = (Price * Quantity).ToString();
                else
                {
                    txtMoney.Text = Price.ToString();
                    txtQuan.Text = "1";
                }
            }
            catch(FormatException)
            {
                txtQuan.Text = "1";
            }
        }

        private void btnAddQuan_Click(object sender, EventArgs e)
        {
            txtQuan.Text = (Int32.Parse(txtQuan.Text) + 1).ToString();
        }

        private void btnIncreaseQuan_Click(object sender, EventArgs e)
        {
            txtQuan.Text = (Int32.Parse(txtQuan.Text) - 1).ToString();
        }

        private void txtQuan_Leave(object sender, EventArgs e)
        {
            if(txtQuan.Text is null)
            {
                txtQuan.Text = "1";
            }    
        }
        public CheckBox myCheckBox = new CheckBox();
        
        private void ProductControl_Load(object sender, EventArgs e)
        {
            myCheckBox.Text = null;
            myCheckBox.Checked = false;
            myCheckBox.Location = new Point(10, 10);
            this.Controls.Add(myCheckBox);
        }
    }
}
