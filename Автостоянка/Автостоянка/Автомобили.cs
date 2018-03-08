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
    public partial class Автомобили : Common.BaseForm
    {
        public Автомобили()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автостоянкаDataSet1.Категория". При необходимости она может быть перемещена или удалена.
            категорияTableAdapter.Fill(автостоянкаDataSet1.Категория);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автостоянкаDataSet1.Клиент". При необходимости она может быть перемещена или удалена.
            клиентTableAdapter.Fill(автостоянкаDataSet1.Клиент);

            АвтомобильTableAdapter.Fill(автостоянкаDataSet1.Автомобиль);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            Common.SqlManipulation.Update(автостоянкаDataSet1, АвтомобильTableAdapter, автостоянкаDataSet1.Автомобиль);
        }
    }
}
