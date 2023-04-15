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
        public static Utilities util;
        //public static EmployeeDTO employeedto { get; set; }
        public int SelectetedRow = 0;

        public fEmployee()
        {
            InitializeComponent();
            LoadData();
            List<Control> listcontrols = new List<Control>() {
                lbEmployeeID,
                txtPassword,
                txtFullName,
                txtSex,
                lbFormatName,
                txtWage,
                picEmployeeImage,
                txtPhoneNumber,
                txtAddress,
                txtCitizenID,
                txtCommissionRate,
                datepkDateOfBirth,
                txtAge,
                lbStatusJob,
                cbAuthorName
            };
            util = new Utilities(listcontrols, gvEmployee);
            util.ListComboxItems = new List<string> { "Manager", "Cashier" };
        }

        public void LoadData()
        {
            AddTestValue();
            gvEmployee.DataSource = EmployeeDAO.Instance.GetDataEmployee();
        }

        private void gvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            util.CellClick();
        }

        private void AddTestValue()
        {
            EmployeeDTO test = new EmployeeDTO("123", "Mai", "FeMale", "Full Time", 27000.5f, "20230415152924454_c758a8b1-939a-4507-bdab-f9c859166011.png", "0123456795", "123 Main Street", "030303110053", 0.5f, new DateTime(2003, 8, 20), "42", "Manager");
            lbEmployeeID.Text = test.EmployeeID.ToString();
            txtPassword.Text = test.Password;
            txtFullName.Text = test.FullName;
            txtSex.Text = test.Sex;
            txtCitizenID.Text = test.CitizenID;
            txtCommissionRate.Text = test.CommissionRate.ToString();
            txtPhoneNumber.Text = test.PhoneNumber.ToString();
            txtAge.Text = test.Age.ToString();
            datepkDateOfBirth.Value = test.DateOfBirth;
            txtAddress.Text = test.Address;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeDTO dto = util.FillDataToDTOClass<EmployeeDTO>();
            string err = "";
            if (dto!=null)
            {
                EmployeeDAO.Instance.AddNewEmployee(dto, ref err);
            }
            if (string.IsNullOrEmpty(err))
                err = "Hoan tat";
            MessageBox.Show(err);
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeDTO dto = util.FillDataToDTOClass<EmployeeDTO>();
            string err = "";
            if (dto!=null)
            {
                EmployeeDAO.Instance.UpdateEmployee(dto, ref err);
            }
            if (string.IsNullOrEmpty(err))
                err = "Hoan tat";
            MessageBox.Show(err);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeDTO dto = util.FillDataToDTOClass<EmployeeDTO>();
            string err = "";
            if (dto!=null)
            {
                EmployeeDAO.Instance.DeleteEmployee(dto, ref err);
            }
            if (string.IsNullOrEmpty(err))
                err = "Hoan tat";
            MessageBox.Show(err);
            LoadData();
        }

        private void picEmployeeImage_Click(object sender, EventArgs e)
        {
            string path = Upload.SaveImageToResources(picEmployeeImage);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
