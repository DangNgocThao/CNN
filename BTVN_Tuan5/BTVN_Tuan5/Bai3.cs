using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == string.Empty || txtLN.Text == string.Empty)
            {
                MessageBox.Show("Thông tin chưa đủ", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = txtFN.Text + ", " + txtLN.Text;
            char c = txtFN.Text[0];
            foreach (TreeNode t in trvDB.Nodes)
            {
                if (t.Text[0] == c)
                {
                    trvDB.Nodes[t.Index].Nodes.Add(name);
                    trvDB.ExpandAll();
                    break;
                }
            }
            txtFN.Clear();
            txtLN.Clear();
            txtFN.Focus();
        }

        private void txtFN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }
    }
}
