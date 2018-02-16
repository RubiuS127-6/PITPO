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
    public partial class ЕдИзмВремени : Form
    {


        public ЕдИзмВремени()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlManipulation.Fill(автостоянкаDataSet1, ЕдИзмВремениTableAdapter, автостоянкаDataSet1.ЕдИзмВремени);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlManipulation.Update(автостоянкаDataSet1, ЕдИзмВремениTableAdapter, автостоянкаDataSet1.ЕдИзмВремени);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            SqlManipulation.Update(автостоянкаDataSet1, ЕдИзмВремениTableAdapter, автостоянкаDataSet1.ЕдИзмВремени);

        }
    }
}
