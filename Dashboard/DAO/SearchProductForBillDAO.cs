using Dashboard.DTO;
using Dashboard.GUI.Panel;
using Dashboard.GUI.Panel.Bill;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Dashboard.DAO
{
    public class SearchProductForBillDAO
    {
        private static SearchProductForBillDAO instance;

        public static SearchProductForBillDAO Instance
        {
            get { if (instance == null) instance = new SearchProductForBillDAO(); return instance; }
            private set { instance = value; }
        }
        public ProductInBillDTO getProduct(string productID)
        {
            ProductInBillDTO dt = null;

            string query = "SELECT * FROM searchProduct ( @productID , @productName , @quantity , @typeName " +
                ", @brandName , @importPrice , @sellPrice , @descript )";
            object[] parameters = new object[] { productID , null , null , null ,null,null,null,null };
            DataTable product = DataProvider.Instance.ExecuteQuery(query, parameters);
            foreach (DataRow dr in product.Rows)
            {
                dt.productID = dr["productID"].ToString();
                dt.productName = dr["productName"].ToString();
                dt.price = float.Parse(dr["sellPrice"].ToString());
                dt.Image = dr["productImageURL"].ToString();
                dt.quantity = 1;
            }
            return dt;
        }
    }
}
