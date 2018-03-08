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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            КлиентыButton.Tag = typeof(Клиенты);
            МестаToolStripButton.Tag = typeof(ПарковочныеМеста);
            ЕдИзмВремToolStripButton.Tag = typeof(ЕдИзмВремени);
            АвтомобилиToolStripButton.Tag = typeof(Автомобили);
            КатегорииToolStripButton.Tag = typeof(Категории);
            СтоянкаToolStripButton.Tag = typeof(Стоянка);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var b = sender as ToolStripButton;
            if (b == null) return;

            var t = b.Tag as Type;
            if (t == null) return;

            Common.FormManager.Instance.OpenForm(t);
        }
    }
}
