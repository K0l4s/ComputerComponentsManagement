using Dashboard.DTO;
using Dashboard.GUI.Panel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable LoadTable(ProductDTO product = null)
        {
            DataTable dt = null;

            string query = "SELECT * FROM searchProduct ( @productID , @productName , @quantity , @typeName " +
                ", @brandName , @importPrice , @sellPrice , @descript )";
            object[] parameters = new object[] { product.productID , product.productName ,
                product.quantity , product.typeName
            , product.brandName , product.importPrice , product.sellPrice , product.descript };
            dt = DataProvider.Instance.ExecuteQuery(query, parameters);

            return dt;
        }
        public string AddCustomer(ProductDTO product)
        {
            string err = "";
            int e;
            try
            {
                string query = "EXECUTE insertProduct @productID , @productName , @quantity , @typeName , @productImageUR0L , @brandName , @importPrice , @sellPrice , @descript ";
                object[] parameters = new object[] { product.productID , product.productName ,
                product.quantity , product.typeName , product.productImageURL
            , product.brandName , product.importPrice , product.sellPrice , product.descript };
                e = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                err = "Tạo tài khoản thành công";
            }

            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
    }
}
