using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.GUI
{
    public partial class MyTeam : Form
    {
        public MyTeam()
        {
            InitializeComponent();
        }

        private void MyTeam_Load(object sender, EventArgs e)
        {

        }

        private void linkKien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kien_url();
        }
        private void Kien_url()
        {
            string url = "https://www.facebook.com/100007960782374";

            // Tạo một đối tượng ProcessStartInfo
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            // Mở trang web trong trình duyệt web mới
            Process.Start(psi);
        }

        private void fbKien_Click(object sender, EventArgs e)
        {
            Kien_url();
        }
    }
}
