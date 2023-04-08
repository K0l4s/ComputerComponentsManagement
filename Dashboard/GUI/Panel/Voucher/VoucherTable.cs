using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI.Panel.Voucher
{
    public partial class VoucherTable : Form
    {
        DataView dtv;
        public VoucherTable(DataTable dt)
        {
            InitializeComponent();
            //MessageBox.Show("Hiển thị được kết quả! Hàm được gọi!");
            dtv = new DataView(dt);
            dtgvTable.DataSource = dtv;
        }
    }
}
