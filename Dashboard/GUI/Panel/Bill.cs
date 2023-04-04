using Dashboard.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Panel
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            Load_Bill();
        }
        public void Load_Bill()
        {
            string query = "SELECT * FROM COMPLETED_BILL";
            dtgvBill.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
