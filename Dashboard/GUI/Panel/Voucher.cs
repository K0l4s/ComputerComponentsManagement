using Dashboard.DAO;
using Dashboard.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dashboard.GUI.Panel.Voucher
{
    public partial class Voucher : Form
    {
        DataTable dta=null;
        private static Voucher instance;
        public static Voucher Instance
        {
            get { if (instance == null) instance = new Voucher(); return Voucher.instance; }
            private set { Voucher.instance = value; }
        }
        public Voucher()
        {
            InitializeComponent();
            
        }
        

        private void Voucher_Load(object sender, EventArgs e)
        {
            panelTools.Visible = false;
            TableDefault();
        }
        private void TableDefault()
        {
            dta = VoucherDAO.Instance.LoadTable();
            dtgvTable.DataSource = dta;
        }
        private void btnCloseTool_Click(object sender, EventArgs e)
        {
            panelTools.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnTools.Text == "Tìm kiếm")
            {
                
                find_Info();
            }
            else if(btnTools.Text == "Thêm")
            {
                add_Info();
            }    
            else if(btnTools.Text == "Xóa")
            {
                delete_Info();
            }
            else if (btnTools.Text == "Sửa")
            {
                update_Info();
            }
        }
        private void update_Info()
        {
            try
            {
                string err;
                string voucherID = null, voucherName = null;
                int? reduction = null;
                int? limit = null, used = null;
                DateTime? expiry = null;
                if (!String.IsNullOrEmpty(txtID.Text))
                    voucherID = txtID.Text;
                if (!String.IsNullOrEmpty(txtName.Text))
                    voucherName = txtName.Text;
                if (!String.IsNullOrEmpty(txtReduction.Text))
                    try
                    {
                        reduction = Int32.Parse(txtReduction.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtLimit.Text))
                    try
                    {
                        limit = Int32.Parse(txtLimit.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtNumberUsed.Text))
                    try
                    {
                        used = Int32.Parse(txtNumberUsed.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtDay.Text) || !String.IsNullOrEmpty(txtMonth.Text) || !String.IsNullOrEmpty(txtYear.Text))
                    try
                    {
                        expiry = new DateTime(Int32.Parse(txtYear.Text), Int32.Parse(txtMonth.Text), Int32.Parse(txtDay.Text));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }

                err = VoucherDAO.Instance.UpdateVoucher(voucherID, voucherName, reduction, expiry, limit, used);
                TableDefault();
                MessageBox.Show(err);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi của bạn có thể từ dữ liệu. Thử lại nhé! \n Mã lỗi:" + ex.ErrorCode + "\n Nội dung: " + ex.Errors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lẽ bạn gặp phải lỗi rồi. Liên hệ DEVELOPER để được hỗ trợ nhé! \n Nội dung lỗi:" + ex.Message);
            }
        }
        private void delete_Info()
        {
            try
            {
                string err;
                string voucherID = null;

                if (!String.IsNullOrEmpty(txtID.Text))
                    voucherID = txtID.Text;
                err = VoucherDAO.Instance.DeleteVoucher(voucherID);
                MessageBox.Show(err);
                TableDefault();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi của bạn có thể từ dữ liệu. Thử lại nhé! \n Mã lỗi:" + ex.ErrorCode + "\n Nội dung: " + ex.Errors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lẽ bạn gặp phải lỗi rồi. Liên hệ DEVELOPER để được hỗ trợ nhé! \n Nội dung lỗi:" + ex.Message);
            }
        }
        private void add_Info()
        {
            try
            {
                string err;
                string voucherID = null, voucherName = null, status = null;
                int? reduction = null; 
                int? limit = null, used = null;
                DateTime? expiry = null;
                if (!String.IsNullOrEmpty(txtID.Text)) 
                    voucherID = txtID.Text;
                if (!String.IsNullOrEmpty(txtName.Text))
                    voucherName = txtName.Text;
                if (!String.IsNullOrEmpty(cbStatus.Text))
                    status = cbStatus.Text;
                if (!String.IsNullOrEmpty(txtReduction.Text))
                    try
                    {
                        reduction = Int32.Parse(txtReduction.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtLimit.Text))
                    try
                    {
                        limit = Int32.Parse(txtLimit.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtNumberUsed.Text))
                    try
                    {
                        used = Int32.Parse(txtNumberUsed.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtDay.Text) || !String.IsNullOrEmpty(txtMonth.Text) || !String.IsNullOrEmpty(txtYear.Text))
                    try
                    {
                        expiry = new DateTime(Int32.Parse(txtYear.Text), Int32.Parse(txtMonth.Text), Int32.Parse(txtDay.Text));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }

                err = VoucherDAO.Instance.AddVoucher(voucherID, voucherName, reduction, status, expiry, limit, used);
                TableDefault();
                MessageBox.Show(err);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi của bạn có thể từ dữ liệu. Thử lại nhé! \n Mã lỗi:" + ex.ErrorCode + "\n Nội dung: " + ex.Errors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lẽ bạn gặp phải lỗi rồi. Liên hệ DEVELOPER để được hỗ trợ nhé! \n Nội dung lỗi:" + ex.Message);
            }
        }    
        private void find_Info()
        {
            try
            {
                string voucherID = null, voucherName = null, status = null;
                int? reduction = null;
                int? limit = null, used = null;
                DateTime? expiry = null;
                if (!String.IsNullOrEmpty(txtID.Text))
                    voucherID = txtID.Text;
                if (!String.IsNullOrEmpty(txtName.Text))
                    voucherName = txtName.Text;
                if (!String.IsNullOrEmpty(cbStatus.Text))
                    status = cbStatus.Text;
                if (!String.IsNullOrEmpty(txtReduction.Text))
                    try
                    {
                        reduction = Int32.Parse(txtReduction.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtLimit.Text))
                    try
                    {
                        limit = Int32.Parse(txtLimit.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtNumberUsed.Text))
                    try
                    {
                        used = Int32.Parse(txtNumberUsed.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }
                if (!String.IsNullOrEmpty(txtDay.Text) || !String.IsNullOrEmpty(txtMonth.Text) || !String.IsNullOrEmpty(txtYear.Text))
                    try
                    {
                        expiry = new DateTime(Int32.Parse(txtYear.Text), Int32.Parse(txtMonth.Text), Int32.Parse(txtDay.Text));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Có lẽ tham số truyền vào không hợp lệ rồi! Thử lại sau nhé!");
                    }

                dta = VoucherDAO.Instance.LoadTable(voucherID, voucherName, reduction, status, expiry, limit, used);
                dtgvTable.DataSource = dta;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi của bạn có thể từ dữ liệu. Thử lại nhé! \n Mã lỗi:" +ex.ErrorCode +"\n Nội dung: " +ex.Errors   );
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lẽ bạn gặp phải lỗi rồi. Liên hệ DEVELOPER để được hỗ trợ nhé! \n Nội dung lỗi:" + ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Tìm kiếm";
            panelTools.Visible = true;
            txtDay.Enabled = true;
            txtID.Enabled = true;
            txtLimit.Enabled = true;
            txtMonth.Enabled = true;
            txtName.Enabled = true;
            txtNumberUsed.Enabled = true;
            txtReduction.Enabled = true;
            txtYear.Enabled = true;
            cbStatus.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Thêm";
            panelTools.Visible = true;
            txtDay.Enabled = true;
            txtID.Enabled = true;
            txtLimit.Enabled = true;
            txtMonth.Enabled = true;
            txtName.Enabled = true;
            txtNumberUsed.Enabled = true;
            txtReduction.Enabled = true;
            txtYear.Enabled = true;
            cbStatus.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Xóa";
            panelTools.Visible = true;
            txtID.Enabled = true;
            txtDay.Enabled = false;
            txtLimit.Enabled = false;
            txtMonth.Enabled = false;
            txtName.Enabled = false;
            txtNumberUsed.Enabled = false;
            txtReduction.Enabled = false;
            txtYear.Enabled = false;
            cbStatus.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnTools.Text = "Sửa";
            panelTools.Visible = true;
            txtDay.Enabled = true;
            txtID.Enabled = true;
            txtLimit.Enabled = true;
            txtMonth.Enabled = true;
            txtName.Enabled = true;
            txtNumberUsed.Enabled = true;
            txtReduction.Enabled = true;
            txtYear.Enabled = true;
            cbStatus.Enabled = false;
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TableDefault();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtReduction.Text = null;
            cbStatus.Text = null;
            txtDay.Text = null;
            txtMonth.Text = null;
            txtLimit.Text = null;
            txtYear.Text = null;
            txtLimit.Text = null;
            txtNumberUsed.Text = null;
        }

        private void dtgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTable.Rows[e.RowIndex];
                string voucherID = row.Cells["voucherID"].Value.ToString();
                string voucherName = row.Cells["voucherName"].Value.ToString();
                DateTime? expiryDate = row.Cells["expiryDate"].Value as DateTime?;
                string status = row.Cells["status"].Value.ToString();
                string percentReduction = row.Cells["PercentReduction"].Value.ToString();
                string limitNumber = row.Cells["limitNumber"].Value.ToString();
                string numberUsed = row.Cells["numberUsed"].Value.ToString();
                txtID.Text = voucherID;
                txtName.Text = voucherName;
                cbStatus.Text = status;
                txtReduction.Text = percentReduction;
                txtLimit.Text = limitNumber;
                txtNumberUsed.Text = numberUsed;
                
                if (expiryDate.HasValue)
                {
                    txtDay.Text = expiryDate.GetValueOrDefault().Day.ToString();
                    txtMonth.Text = expiryDate.GetValueOrDefault().Month.ToString();
                    txtYear.Text = expiryDate.GetValueOrDefault().Year.ToString();
                }
                else
                {
                    txtDay.Text = "";
                    txtMonth.Text = "";
                    txtYear.Text = "";
                }
            }
        }
    }
}
