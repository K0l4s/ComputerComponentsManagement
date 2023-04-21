using Dashboard.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DTO
{
    public class ProductDTO
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public byte[] productImageURL { get; set; }
        public int? quantity { get; set; }
        public string typeName { get; set; }
        public string typeID { get; set; }
        public string brandID { get; set; }
        public string brandName { get; set; }
        public float? importPrice { get; set; }
        public float? sellPrice { get; set; }
        public string descript { get; set; }
        public void ProductGet(string productID = null, string productName = null, byte[] productImageURL = null,
            int? quantity = null, string typeName = null, string brandName = null, float? importPrice = null, float? sellPrice = null, string descript = null,string typeID = null, string brandID = null)
        {
            this.productID = productID;
            this.productName = productName;
            this.productImageURL = productImageURL;
            this.quantity = quantity;
            this.typeName = typeName;
            this.brandName = brandName;
            this.importPrice = importPrice;
            this.sellPrice = sellPrice;
            this.descript = descript;
            this.typeID = typeID;
            this.brandID = brandID;
        }
    }
}
