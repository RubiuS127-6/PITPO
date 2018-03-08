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
    public partial class Стоянка : Common.BaseForm
    {
        private АвтостоянкаDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private АвтостоянкаDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private АвтостоянкаDataSetTableAdapters.Парковочное_местоTableAdapter парковочное_местоTableAdapter;
        private АвтостоянкаDataSetTableAdapters.Стоянки_Парковочные_местаTableAdapter стоянки_Парковочные_местаTableAdapter;

        public Стоянка()
        {
            InitializeComponent();

            new Common.DataGridViewDateTimeCellFormatting(this.стоянкаDataGridView);

            стоянкаDataGridView.CellValueNeeded += DataGridView1_CellValueNeeded;
            стоянкаDataGridView.CellValuePushed += DataGridView1_CellValuePushed;
        }

        private void DataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (стоянкаDataGridView.Columns[e.ColumnIndex] != МестаColumn) return;

            var dgvr = стоянкаDataGridView.Rows[e.RowIndex];
            var drv = dgvr.DataBoundItem as DataRowView;
            if (drv == null || drv.Row == null) return;

            var стоянка = drv.Row as АвтостоянкаDataSet.СтоянкаRow;

            var местаStr = e.Value as string;

            if (местаStr == null) return;

            var местаStrArr = местаStr.Split(',');

            стоянки_Парковочные_местаTableFill();

            var местаArr = местаStrArr.Select(q => q.Trim()).Select(место => автостоянкаDataSet.Парковочное_место.FirstOrDefault(q => q.Номер == место)).Where(q => q != null).ToList();
            var местаArrOrig = автостоянкаDataSet.Парковочное_место.Where(место => место.GetСтоянки_Парковочные_местаRows().Any(q => q.ID_Стоянки == стоянка.Код)).Where(q => q != null).ToList();

            if (местаArrOrig.Select(q => q.Код).Except(местаArr.Select(q => q.Код)).Any() || местаArr.Select(q => q.Код).Except(местаArrOrig.Select(q => q.Код)).Any())
            {
                foreach (var стоянки_Парковочные_места in автостоянкаDataSet.Стоянки_Парковочные_места.Where(q => q.ID_Стоянки == стоянка.Код).ToList())
                {
                    автостоянкаDataSet.Стоянки_Парковочные_места.RemoveСтоянки_Парковочные_местаRow(стоянки_Парковочные_места);
                }

                foreach (var парковочное_место in местаArr)
                {
                    автостоянкаDataSet.Стоянки_Парковочные_места.AddСтоянки_Парковочные_местаRow(стоянка, парковочное_место);
                }

                Common.SqlManipulation.Update(автостоянкаDataSet, стоянки_Парковочные_местаTableAdapter, автостоянкаDataSet.Стоянки_Парковочные_места);
                стоянки_Парковочные_местаTableFill();
            }
        }

        private void DataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (стоянкаDataGridView.Columns[e.ColumnIndex] != МестаColumn) return;

            var dgvr = стоянкаDataGridView.Rows[e.RowIndex];
            var drv = dgvr.DataBoundItem as DataRowView;
            if (drv == null || drv.Row == null) return;

            var стоянка = drv.Row as АвтостоянкаDataSet.СтоянкаRow;

            стоянки_Парковочные_местаTableFill();

            var Стоянки_Парковочные_местапаркМеста = автостоянкаDataSet.Стоянки_Парковочные_места.Where(q => q.ID_Стоянки == стоянка.Код).Select(q => q.Код).ToList();
            var местаArrOrig = автостоянкаDataSet.Парковочное_место.Where(q => Стоянки_Парковочные_местапаркМеста.Contains(q.Код)).Select(q => q.Номер).ToList();

            if (местаArrOrig != null && местаArrOrig.Any())
                e.Value = местаArrOrig.Aggregate((s, q) => s + ", " + q);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            категорияTableAdapter = new АвтостоянкаDataSetTableAdapters.КатегорияTableAdapter();
            клиентTableAdapter = new АвтостоянкаDataSetTableAdapters.КлиентTableAdapter();
            парковочное_местоTableAdapter = new АвтостоянкаDataSetTableAdapters.Парковочное_местоTableAdapter();
            стоянки_Парковочные_местаTableAdapter = new АвтостоянкаDataSetTableAdapters.Стоянки_Парковочные_местаTableAdapter();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "автостоянкаDataSet.ЕдИзмВремени". При необходимости она может быть перемещена или удалена.
            едИзмВремениTableAdapter.Fill(автостоянкаDataSet.ЕдИзмВремени);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автостоянкаDataSet.Автомобиль". При необходимости она может быть перемещена или удалена.
            автомобильTableAdapter.Fill(автостоянкаDataSet.Автомобиль);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автостоянкаDataSet.Стоянка". При необходимости она может быть перемещена или удалена.
            стоянкаTableAdapter.Fill(автостоянкаDataSet.Стоянка);

            категорияTableAdapter.Fill(автостоянкаDataSet.Категория);

            клиентTableAdapter.Fill(автостоянкаDataSet.Клиент);

            парковочное_местоTableAdapter.Fill(автостоянкаDataSet.Парковочное_место);

            стоянки_Парковочные_местаTableFill();
        }

        void стоянки_Парковочные_местаTableFill()
        {
            стоянки_Парковочные_местаTableAdapter.Fill(автостоянкаDataSet.Стоянки_Парковочные_места);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            Common.SqlManipulation.Update(автостоянкаDataSet, стоянкаTableAdapter, автостоянкаDataSet.Стоянка);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void стоянкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.стоянкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автостоянкаDataSet);

        }

        private void стоянкаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.стоянкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автостоянкаDataSet);

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
