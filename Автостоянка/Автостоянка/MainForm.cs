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
            toolStripButton1.Tag = typeof(ПарковочныеМеста);
            toolStripButton2.Tag = typeof(ЕдИзмВремени);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var b = sender as ToolStripButton;
            if (b == null) return;

            var t = b.Tag as Type;
            if (t == null) return;

            FormManager.Instance.OpenForm(t);
        }
    }
}
