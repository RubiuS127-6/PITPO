using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public class DataGridViewDateTimeCellFormatting
    {

        DataGridView _dataGridView;

        public DataGridViewDateTimeCellFormatting(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            SetColumnMasked();
        }

        private void SetColumnMasked()
        {
            maskedTextBox = new MaskedTextBox();
            maskedTextBox.Visible = false;
            maskedTextBox.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

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

        private void _dataGridView_SizeChanged(object sender, EventArgs e) { optimizeSizeAndLocaion(); }

        void _dataGridView_Scroll(object sender, ScrollEventArgs e) { optimizeSizeAndLocaion(); }

        void optimizeSizeAndLocaion(Rectangle? rect = null)
        {
            if (_control != null && _control.Visible)
            {
                _control.Bounds = rect ?? _dataGridView.GetCellDisplayRectangle(_dataGridView.CurrentCell.ColumnIndex, _dataGridView.CurrentCell.RowIndex, false);
            }
        }

        void _dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var column = _dataGridView.Columns[e.ColumnIndex];

            if (!string.IsNullOrEmpty(column.DefaultCellStyle.Format))
            {

                if (column.DefaultCellStyle.Format == "g")
                {
                    _control = dateTimePicker;
                }
                else
                {
                    maskedTextBox.Mask = column.DefaultCellStyle.Format;
                    _control = maskedTextBox;
                }

                if (_dataGridView[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    _control.Text = _dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
                }

                _control.Visible = true;

                optimizeSizeAndLocaion(_dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false));
            }
        }

        void _dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_control != null && _control.Visible)
            {
                _dataGridView.CurrentCell.Value = Convert.ChangeType(_control.Text, _dataGridView.CurrentCell.FormattedValueType);
                _control.Visible = false;
            }
        }

        Control _control;
        DateTimePicker dateTimePicker;
        MaskedTextBox maskedTextBox;

    }
}