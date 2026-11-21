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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool ktTrung(ListView pList, string pValue,int pIndex)
        {
            for (int i = 0; i < pList.Items.Count; i++)
            {
                if (pList.Items[i].SubItems[pIndex].Text == pValue)
                    return true;
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(ktTrung(listView1,txtMa.Text,0))
            {
                MessageBox.Show("Bị trùng", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listView1.Items.Add(txtMa.Text).SubItems.Add(txtTen.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in listView1.SelectedItems)
            {
                l.Remove();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null && listView1.FocusedItem.Index >= 0)
            {
                ListViewItem item = listView1.FocusedItem;
                item.SubItems[0].Text = txtMa.Text;
                item.SubItems[1].Text = txtTen.Text;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMa.Text = listView1.FocusedItem.SubItems[0].Text;
            txtTen.Text = listView1.FocusedItem.SubItems[1].Text;
        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnThem.PerformClick();
        }
    }
}
