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
        }

        private void КлиентыButton_Click(object sender, EventArgs e)
        {
            (new Клиенты() { MdiParent = this }).Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            (new ПарковочныеМеста() { MdiParent = this }).Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            (new ЕдИзмВремени() { MdiParent = this }).Show();
        }
    }
}
