using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void chứcNăng1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chứcNăng2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1OL frm = new Bai1OL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chứcNăng3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2OL frm = new Bai2OL();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
