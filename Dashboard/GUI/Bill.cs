using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            panelAdd.Width = panelTable.Width;
        }
    }
}
