using Dashboard.DAO;
using Dashboard.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class fEmployee : Form
    {
        public static Utilities util ;
        public static EmployeeDTO employeedto { get; set; }
        public int SelectetedRow = 0 ;

        public fEmployee()
        {
            InitializeComponent();
            LoadData();
            List<Control> listcontrols = new List<Control>() {
                lbIdEmployee,
                txtPassword,
                txtFullName,
                txtSex,
                lbFormatName,
                lbWage,
                picEmployeeImage,
                txtPhoneNumber,
                txtAddress,
                txtCitizenID,
                txtCommissionRate,
                datepkDateOfBirth,
                txtAge,
                lbStatusJob,
                lbAuthorName
            };
            util = new Utilities(listcontrols, gvEmployee);
        }

        public void LoadData()
        {
            gvEmployee.DataSource = EmployeeDAO.Instance.getDataEmployee();
        }

        private void gvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            util.CellClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //EmployeeDTO dto = util.FillDataToDTOClass<EmployeeDTO>();
            EmployeeDTO dto = new EmployeeDTO("123", "Mai", "FeMale", "Full Time",27000.5f, null, "0123456795", "123 Main Street", "030303110053","0,1", new DateTime(2003, 8, 20), "42" ,"Manager");

            string err = "Hoan tat";
            if(dto!=null)
            {
                EmployeeDAO.Instance.addNewEmployee(dto,ref err);
            }
            MessageBox.Show(err);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void picEmployeeImage_Click(object sender, EventArgs e)
        {
            string path = Upload.SaveImageToResources(picEmployeeImage);
            MessageBox.Show(Upload.GetImageName(path));

        }
    }
}
