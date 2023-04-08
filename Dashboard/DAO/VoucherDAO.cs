using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard.DTO;

namespace Dashboard.DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO instance;

        public static VoucherDAO Instance
        {
            get { if (instance == null) instance = new VoucherDAO(); return instance; }
            private set { instance = value; }
        }

<<<<<<< HEAD
        }
        
        public DataTable ConvertDTOToTable(VoucherDTO a)
=======
        private VoucherDAO() { }

        public DataTable LoadTable(string voucherID, string voucherName, string percentReduction,string status, string expiryDate, string limitNumber, string numberUsed)
>>>>>>> 0c6fea3820eaa22e760312ed94971966266b89ec
        {
            DataTable dt = null;
            
            return dt;
        }
    }
}
