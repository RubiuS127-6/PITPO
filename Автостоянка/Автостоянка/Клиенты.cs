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
    public partial class Клиенты : Common.BaseForm
    {
        public Клиенты()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            КлиентTableAdapter.Fill(автостоянкаDataSet1.Клиент);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            Common.SqlManipulation.Update(автостоянкаDataSet1, КлиентTableAdapter, автостоянкаDataSet1.Клиент);
        }
    }
}
