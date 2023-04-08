using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DTO
{
    public class VoucherDTO
    {
        public string voucherID { get; set; }
        public string voucherName { get; set; }
        public float percentReduction { get; set; }
        public string status { get; set; }
        public DateTime expiryDate { get; set; }
        public int limitNumber { get; set; }
        public int numberUsed { get; set; }
        public VoucherDTO(string voucherID, string voucherName, float percentReduction,string status, DateTime expiryDate, int limitNumber, int numberUsed)
        {
            this.status = status;
            this.voucherID = voucherID;
            this.voucherName = voucherName;
            this.percentReduction = percentReduction;
            this.expiryDate = expiryDate;
            this.limitNumber = limitNumber;
            this.numberUsed = numberUsed;
        }
    }
}
