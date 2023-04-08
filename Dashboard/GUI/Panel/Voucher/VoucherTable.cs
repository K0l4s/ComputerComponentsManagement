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
        public VoucherTable(DataTable dt)
        {
            InitializeComponent();
            dtgvTable.Refresh();
            dtgvTable.DataSource = dt;
        }
    }
}
