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
    public partial class Категории : BaseForm
    {
        public Категории()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            КатегорияTableAdapter.Fill(автостоянкаDataSet1.Категория);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            SqlManipulation.Update(автостоянкаDataSet1, КатегорияTableAdapter, автостоянкаDataSet1.Категория);
        }
    }
}
