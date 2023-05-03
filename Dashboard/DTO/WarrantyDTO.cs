using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DTO
{
    public class WarrantyDTO
    {
        public string warrantyID { get; set; }
        public string productID { get; set; }
        public string productName { get; set; }
        public string billID { get; set; }
        public int? quantity { get; set; }
        public int? warr_statusID { get; set; }
        public string descript { get; set; }
        public WarrantyDTO(string warrantyID, string productID, string productName, string billID, int? quantity, int? warr_statusID, string descript)
        {
            this.warrantyID = warrantyID;
            this.productID = productID;
            this.productName = productName;
            this.billID = billID;
            this.quantity = quantity;
            this.warr_statusID = warr_statusID;
            this.descript = descript;
        }
    }
}
