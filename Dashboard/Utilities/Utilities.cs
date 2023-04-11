using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public class Utilities
    {
        private List<Control> Controls { get; set; }
        private DataGridView DataGV { get; set; }

        public Utilities(List<Control> controls, DataGridView dataGridView)
        {
            Controls = new List<Control>(controls);
            DataGV = dataGridView;
        }

        public void SetNullTextBox()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox || control is RichTextBox || control is ComboBox)
                {
                    control.Text = "";
                }
                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = -1;
                }
            }
        }

        public bool IsNullTextBox()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox || control is RichTextBox || control is ComboBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        return true;
                    }
                }
                if (control is ComboBox)
                {
                    if ((control as ComboBox).SelectedIndex == -1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void DisplayDataRow()
        {
            try
            {
                if (DataGV.CurrentCell == null)
                {
                    SetNullTextBox();
                    return;
                }
                int selectedRowIndex = DataGV.SelectedCells[0].RowIndex;

                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is DateTimePicker)
                    {
                        string value = DataGV.Rows[selectedRowIndex].Cells[i].Value?.ToString().Trim();
                        if (!string.IsNullOrEmpty(value))
                        {
                            DateTime dateTimeValue;
                            if (DateTime.TryParse(value, out dateTimeValue))
                            {
                                ((DateTimePicker)Controls[i]).Value = dateTimeValue;
                            }
                        }
                    }
                    else if (Controls[i] is PictureBox)
                    {
                        byte[] value = DataGV.Rows[selectedRowIndex].Cells[i].Value as byte[];
                        if (value != null && value.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(value))
                            {
                                ((PictureBox)Controls[i]).Image = Image.FromStream(ms);
                            }
                        }
                    }
                    Controls[i].Text = DataGV.Rows[selectedRowIndex].Cells[i].Value?.ToString().Trim();
                }
            }
            catch
            {
                MessageBox.Show("Thao tác quá nhanh, vui lòng thực hiện lại!!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ShowSelectedRow()
        {
            DisplayDataRow();
        }

        public void CellClick()
        {
            ShowSelectedRow();
        }

        public T FillDataToDTOClass<T>()
        {
            T dto = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in typeof(T).GetProperties())
            {
                if (propInfo.CanWrite)
                {
                    // Get the control that matches the property name
                    Control control = Controls.FirstOrDefault(c => c.Name.Contains(propInfo.Name));

                    if (control != null)
                    {
                        object value = null;

                        if (propInfo.PropertyType == typeof(DateTime))
                        {
                            string date = control.Text;//08/
                            DateTime.ParseExact(date, "dd/MM/yyyy", null);
                        }
                        else if (propInfo.PropertyType == typeof(byte[]))
                        {
                            if (control is PictureBox pictureBox && pictureBox.Image != null)
                            {
                                value = DataConvert.ImgToByteArray(pictureBox.Image);
                            }
                        }
                        else
                        {
                            value = string.IsNullOrEmpty(control.Text)  ? Convert.ChangeType(control.Text, propInfo.PropertyType) : null;
                        }

                        // Set the property value on the DTO object
                        propInfo.SetValue(dto, value);
                    }
                }
            }

            return dto;
        }

    }
}
