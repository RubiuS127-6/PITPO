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
    public partial class ПарковочныеМеста : Common.BaseForm
    {
        public ПарковочныеМеста()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            парковочное_местоTableAdapter.Fill(автостоянкаDataSet1.Парковочное_место);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            Common.SqlManipulation.Update(автостоянкаDataSet1, парковочное_местоTableAdapter, автостоянкаDataSet1.Парковочное_место);
        }
    }
}
