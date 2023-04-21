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
        public void LoadComboBoxType(ComboBox cb)
        {
            string query = "SELECT * FROM PRODUCT_TYPE";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            cb.DataSource = dt;
            cb.DisplayMember = "typeName";
            cb.ValueMember = "typeID";
        }
        public void LoadComboBoxBrand(ComboBox cb)
        {
            string query = "SELECT * FROM BRAND";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            cb.DataSource = dt;
            cb.DisplayMember = "brandName";
            cb.ValueMember = "brandID";
        }
        public string AddProduct(ProductDTO product)
        {
            string err = "";
            try
            {
                string query = "EXECUTE insertProduct @productID , @productName , @quantity , @typeID "
                    + ", @brandID , @importPrice , @sellPrice , @descript , @productImageUR0L ";
                object[] parameters = new object[] { product.productID , product.productName ,
                product.quantity , product.typeID
                , product.brandID , product.importPrice , product.sellPrice , product.descript , product.productImageURL};
                DataTable e = DataProvider.Instance.ExecuteQuery(query, parameters);
                err = "Thêm sản phẩm thành công";
            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string DeleteProduct(ProductDTO product)
        {
            string err = "";
            string query = "EXECUTE deleteProductByID @productID ";
            object[] parameters = new object[] { product.productID };
            DataTable e = DataProvider.Instance.ExecuteQuery(query, parameters);
            err = "Xóa sản phẩm thành công";
            return err;
        }
        public string UpdateProduct(ProductDTO product)
        {
            string err = "";
            try
            {
                string query = "EXECUTE updateProductByID @productID , @productName , @quantity , @typeID "
                    + ", @brandID , @importPrice , @sellPrice , @descript , @productImageUR0L ";
                object[] parameters = new object[] { product.productID , product.productName ,
                product.quantity , product.typeID
                , product.brandID , product.importPrice , product.sellPrice , product.descript , product.productImageURL};
                DataTable e = DataProvider.Instance.ExecuteQuery(query, parameters);
                err = "Chỉnh sản phẩm thành công";
            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }
            return err;
        }
    }
}
