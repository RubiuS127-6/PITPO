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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default["ConnectionString"] = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Автостоянка.accdb";
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автостоянкаDataSet1.Парковочное_место". При необходимости она может быть перемещена или удалена.
            this.парковочное_местоTableAdapter.Fill(this.автостоянкаDataSet1.Парковочное_место);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            автостоянкаDataSet1.Парковочное_место.AcceptChanges();
            автостоянкаDataSet1.AcceptChanges();
            автостоянкаDataSet1.Парковочное_место.AcceptChanges();
            //парковочное_местоTableAdapter.Adapter.Fill(автостоянкаDataSet1);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            автостоянкаDataSet1.Парковочное_место.AcceptChanges();
            автостоянкаDataSet1.AcceptChanges();
            автостоянкаDataSet1.Парковочное_место.AcceptChanges();
            //парковочное_местоTableAdapter.Adapter.Fill(автостоянкаDataSet1);
        }
    }
}
