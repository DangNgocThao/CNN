using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void đồngHồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Form1")
                {
                    kt = true;
                    item.Focus();
                    break;
                }
            }
            if (kt == false)
            {
                Form1 frm = new Form1();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
