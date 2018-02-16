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
    public partial class ЕдИзмВремени : BaseForm
    {


        public ЕдИзмВремени()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlManipulation.Fill(автостоянкаDataSet1, ЕдИзмВремениTableAdapter, автостоянкаDataSet1.ЕдИзмВремени);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            SqlManipulation.Update(автостоянкаDataSet1, ЕдИзмВремениTableAdapter, автостоянкаDataSet1.ЕдИзмВремени);

        }
    }
}
