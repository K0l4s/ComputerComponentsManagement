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
        private VoucherDAO()
        {

        }
        
        public DataTable ConvertDTOToTable(VoucherDTO a)
        {
            DataTable dt = null;
            
            return dt;
        }
    }
}
