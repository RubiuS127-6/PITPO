using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Common
{

    /// <summary>
    /// DataGridViewMaskedTextCell is derived from DGV-TextBoxCell using all TextBox
    /// properties and containing the Mask property to host a MaskedTextBox.
    /// </summary>
    public class DataGridViewMaskedTextCell : DataGridViewTextBoxCell
    {

        #region Fields
        private static Type cellType = typeof(DataGridViewMaskedTextCell);
        private Type valueType = typeof(string);
        private static Type editorType = typeof(DataGridViewMaskedTextEditingControl);
        #endregion

        #region Constructor, Clone, ToString

        public DataGridViewMaskedTextCell() : base()
        {
            Mask = String.Empty;
        }

        /// <summary>
        /// Creates a copy of a DGV-MaskedTextCell containing the DGV-Cell properties.
        /// </summary>
        /// <returns>Instance of a DGV-MaskedTextCell using the Mask string.</returns>
        public override object Clone()
        {
            DataGridViewMaskedTextCell cell = base.Clone() as DataGridViewMaskedTextCell;
            cell.Mask = this.Mask;
            return cell;
        }

        /// <summary>
        /// Converting the current DGV-MaskedTextCell instance to a string value.
        /// </summary>
        /// <returns>String value of the instance containing the type name, 
        /// column index, and row index.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(0x40);
            builder.Append("DataGridViewMaskedTextCell { ColumnIndex=");
            builder.Append(ColumnIndex.ToString());
            builder.Append(", RowIndex=");
            builder.Append(RowIndex.ToString());
            builder.Append(" }");
            return builder.ToString();
        }

        #endregion

        #region Derived methods

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public override void DetachEditingControl()
        {
            DataGridView dataGridView = DataGridView;
            if ((dataGridView == null) || (dataGridView.EditingControl == null))
            {
                throw new InvalidOperationException();
            }
            MaskedTextBox editingControl = dataGridView.EditingControl as MaskedTextBox;
            if (editingControl != null)
            {
                editingControl.ClearUndo();
            }
            base.DetachEditingControl();
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            DataGridViewMaskedTextEditingControl editingControl                = base.DataGridView.EditingControl as DataGridViewMaskedTextEditingControl;
            if (editingControl != null)
            {
                if (Value == null || Value is DBNull)
                    editingControl.Text = (string)DefaultNewRowValue;
                else
                    editingControl.Text = (string)Value;
            }
        }

        #endregion

        #region Derived properties

        public override Type EditType { get { return editorType; } }

        public override Type ValueType { get { return valueType; } }

        #endregion

        #region Additional Mask property 

        private string mask;

        /// <summary>
        /// Input String that rules the possible input values in the current cell of the column.
        /// </summary>
        public string Mask
        {
            get { return mask == null ? String.Empty : mask; }
            set { mask = value; }
        }

        #endregion

    }

}
