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
    public partial class ПарковочныеМеста : Form
    {
        const string connectingString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Автостоянка.accdb";


        public ПарковочныеМеста()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlManipulation.Fill(автостоянкаDataSet1, парковочное_местоTableAdapter, автостоянкаDataSet1.Парковочное_место);

            //this.парковочное_местоTableAdapter.Connection.ConnectionString = connectingString;
            //this.парковочное_местоTableAdapter.Fill(this.автостоянкаDataSet1.Парковочное_место);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlManipulation.Update(автостоянкаDataSet1, парковочное_местоTableAdapter, автостоянкаDataSet1.Парковочное_место);

            //if (!автостоянкаDataSet1.HasChanges()) return;

            //парковочное_местоTableAdapter.Connection.ConnectionString = connectingString;
            //парковочное_местоTableAdapter.Update(автостоянкаDataSet1.Парковочное_место);
            //парковочное_местоTableAdapter.Fill(автостоянкаDataSet1.Парковочное_место);
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

            SqlManipulation.Update(автостоянкаDataSet1, парковочное_местоTableAdapter, автостоянкаDataSet1.Парковочное_место);
            //if (!автостоянкаDataSet1.HasChanges()) return;

            //парковочное_местоTableAdapter.Connection.ConnectionString = connectingString;
            //парковочное_местоTableAdapter.Update(автостоянкаDataSet1.Парковочное_место);
            //парковочное_местоTableAdapter.Fill(автостоянкаDataSet1.Парковочное_место);
        }
    }
}
