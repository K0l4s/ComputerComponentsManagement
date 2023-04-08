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
using Dashboard.DTO;

namespace Dashboard.GUI.Panel.Voucher
{
    public partial class VoucherSearch : Form
    {
        public VoucherSearch()
        {
            InitializeComponent();
            VoucherSearchLoad();
        }
        private void VoucherSearchLoad()
        {
            chbId.Checked = true;
            txtName.Enabled = false;
            txtPercent.Enabled = false;
            txtStatus.Enabled = false;
            dtpExpiryDate.Enabled = false;
            txtLimitNum.Enabled = false;
            txtUsedNum.Enabled = false;
        }
        private void checkBox(CheckBox chb, TextBox txt)
        {
            if (chb.Checked)
                txt.Enabled = true;
            else
                txt.Enabled = false;
        }
        private void chbId_CheckedChanged(object sender, EventArgs e)
        {
            checkBox(chbId, txtId);
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            checkBox(chbName, txtName);
        }

        private void chbPercent_CheckedChanged(object sender, EventArgs e)
        {
            checkBox(chbPercent, txtPercent);
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chbStatus.Checked)
                txtStatus.Enabled = true;
            else
                txtStatus.Enabled = false;
        }

        private void chbExpiryDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbExpiryDate.Checked)
                dtpExpiryDate.Enabled = true;
            else
                dtpExpiryDate.Enabled = false;
        }

        private void chbLimitNum_CheckedChanged(object sender, EventArgs e)
        {
            checkBox(chbLimitNum, txtLimitNum);
        }

        private void chbUsedNum_CheckedChanged(object sender, EventArgs e)
        {
            checkBox(chbUsedNum, txtUsedNum);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            VoucherDTO voucher = new VoucherDTO(null, null, -1, null, new DateTime(01, 01, 0001, 12, 0, 0, 0), -2, -2);

            if (chbId.Checked == true)
            {
                voucher.voucherID = txtId.Text;
            }

            if (chbName.Checked == true)
            {
                voucher.voucherName = txtName.Text;
            }

            float percentReduction;
            if (chbPercent.Checked == true && float.TryParse(txtPercent.Text, out percentReduction))
            {
                voucher.percentReduction = percentReduction;
            }

            if (chbExpiryDate.Checked == true)
            {
                voucher.expiryDate = dtpExpiryDate.Value;
            }

            int limitNumber;
            if (chbLimitNum.Checked  == true && int.TryParse(txtLimitNum.Text, out limitNumber))
            {
                voucher.limitNumber = limitNumber;
            }

            int numberUsed;
            if (chbUsedNum.Checked == true && int.TryParse(txtUsedNum.Text, out numberUsed))
            {
                voucher.numberUsed = numberUsed;
            }

            Voucher vou = new Voucher();
            vou.TableCall(voucher);
        }
    }
}
