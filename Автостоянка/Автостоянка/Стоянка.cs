using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Автостоянка
{
    public partial class Стоянка : BaseForm
    {
        public Стоянка()
        {
            InitializeComponent();

            new DataGridViewCellFormatting(dataGridView1);
        }

        private void DataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var drv = СтоянкаBindingSource.Current as DataRowView;
            if (drv == null || drv.Row == null) return;

            var стоянка = drv.Row as АвтостоянкаDataSet.СтоянкаRow;

            var паркМеста = стоянка.GetСтоянки_Парковочные_местаRows().Select(q => q.Парковочное_местоRow.Номер);
            if (паркМеста != null && паркМеста.Any())
                паркМеста.Aggregate((s, q) => s + ", " + q);
            //e.RowIndex
            //var x = автостоянкаDataSet1.Стоянка.SelectMany(q => q.GetСтоянки_Парковочные_местаRows().Select(r=>r)).Select(q=>q.);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.категорияTableAdapter.Fill(this.автостоянкаDataSet1.Категория);

            this.клиентTableAdapter.Fill(this.автостоянкаDataSet1.Клиент);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "автостоянкаDataSet1.ЕдИзмВремени". При необходимости она может быть перемещена или удалена.
            this.едИзмВремениTableAdapter.Fill(this.автостоянкаDataSet1.ЕдИзмВремени);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автостоянкаDataSet1.Автомобиль". При необходимости она может быть перемещена или удалена.
            this.автомобильTableAdapter.Fill(this.автостоянкаDataSet1.Автомобиль);

            СтоянкаTableAdapter.Fill(автостоянкаDataSet1.Стоянка);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            SqlManipulation.Update(автостоянкаDataSet1, СтоянкаTableAdapter, автостоянкаDataSet1.Стоянка);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }
    }
}




























/*


public partial class Form7 : Form

{

    public Form7()

    {

        InitializeComponent();

    }



    private void Form7_Load(object sender, EventArgs e)

    {

        DataGridViewComboBoxColumn TpyeCol = new DataGridViewComboBoxColumn();

        TpyeCol.Name = "Type";

        TpyeCol.HeaderText = "Type";

        TpyeCol.Items.AddRange(new string[] { "Home Phone", "Cell", "Work", "Email" });

        this.dataGridView1.Columns.Add(TpyeCol);



        this.dataGridView1.Columns.Add("Description", "Description");

        this.dataGridView1.Rows.Add("Home Phone", "");



        this.maskedTextBox = new MaskedTextBox();

        this.maskedTextBox.Visible = false;

        this.dataGridView1.Controls.Add(this.maskedTextBox);



        this.dataGridView1.CellBeginEdit +=

            new DataGridViewCellCancelEventHandler(dataGridView1_CellBeginEdit);



        this.dataGridView1.CellEndEdit +=

            new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);



        this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);

    }



    void dataGridView1_Scroll(object sender, ScrollEventArgs e)
    {
        if (this.maskedTextBox.Visible)
        {
            //we have to adjust the location for the MaskedTextBox while scrolling

            Rectangle rect = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex,this.dataGridView1.CurrentCell.RowIndex, true);

            this.maskedTextBox.Location = rect.Location;
        }

    }



    void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
        if (e.ColumnIndex == this.dataGridView1.Columns["Description"].Index && e.RowIndex < this.dataGridView1.NewRowIndex)

        {

            string type = this.dataGridView1["Type", e.RowIndex].Value.ToString();

            if (type == "Home Phone" || type == "Cell" || type == "Work")

            {

                this.maskedTextBox.Mask = "(###)###-####";

                Rectangle rect =
                   this.dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                this.maskedTextBox.Location = rect.Location;

                this.maskedTextBox.Size = rect.Size;

                this.maskedTextBox.Text = "";

                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)

                {

                    this.maskedTextBox.Text = this.dataGridView1[e.ColumnIndex,
                        e.RowIndex].Value.ToString();

                }

                this.maskedTextBox.Visible = true;

            }

            // if type is Email, do no show the MaskedTextBox

        }

    }



    void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)

    {

        if (this.maskedTextBox.Visible)

        {

            this.dataGridView1.CurrentCell.Value = this.maskedTextBox.Text;

            this.maskedTextBox.Visible = false;

        }

    }



    MaskedTextBox maskedTextBox;

}*/