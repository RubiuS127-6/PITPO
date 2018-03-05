using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Автостоянка
{
    public class DataGridViewCellFormatting
    {

        DataGridView _dataGridView;

        public DataGridViewCellFormatting(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            SetColumnMasked();
        }

        private void SetColumnMasked()
        {
            dateTimePicker = new DateTimePicker();
            dateTimePicker.Visible = false;
            
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd.MM.yyyy hh:mm";
            dateTimePicker.ShowUpDown = true;

            _dataGridView.Controls.Add(dateTimePicker);
            _dataGridView.CellBeginEdit += _dataGridView_CellBeginEdit;
            _dataGridView.CellEndEdit += _dataGridView_CellEndEdit;
            _dataGridView.Scroll += _dataGridView_Scroll;
            _dataGridView.SizeChanged += _dataGridView_SizeChanged;
        }

        private void _dataGridView_SizeChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Visible)
            {
                Rectangle rect = _dataGridView.GetCellDisplayRectangle(_dataGridView.CurrentCell.ColumnIndex, _dataGridView.CurrentCell.RowIndex, true);
                dateTimePicker.Location = rect.Location;
                dateTimePicker.Size = rect.Size;
            }
        }

        void _dataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            if (dateTimePicker.Visible)
            {
                Rectangle rect = _dataGridView.GetCellDisplayRectangle(_dataGridView.CurrentCell.ColumnIndex, _dataGridView.CurrentCell.RowIndex, true);
                dateTimePicker.Location = rect.Location;
                dateTimePicker.Size = rect.Size;
            }
        }

        void _dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var column = _dataGridView.Columns[e.ColumnIndex];
            if (!string.IsNullOrEmpty(column.DefaultCellStyle.Format) && column.DefaultCellStyle.Format == "g")
            {
                //if()
                //maskedTextBox.Mask = column.DefaultCellStyle.Format;

                Rectangle rect = _dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dateTimePicker.Location = rect.Location;
                dateTimePicker.Size = rect.Size;

                dateTimePicker.Text = "";

                if (_dataGridView[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    dateTimePicker.Text = _dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
                }

                dateTimePicker.Visible = true;
            }
        }

        void _dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dateTimePicker.Visible)
            {
                _dataGridView.CurrentCell.Value = dateTimePicker.Text;
                dateTimePicker.Visible = false;
            }

        }

        DateTimePicker dateTimePicker;
        MaskedTextBox maskedTextBox;

    }
}