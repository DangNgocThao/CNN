using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan8
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void thêmSảnPhẩmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Form1")
                {
                    item.Focus();
                    return;
                }
            }
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Form2")
                {
                    item.Focus();
                    return;
                }
            }
            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
