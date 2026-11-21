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
    public partial class Bai1OL : Form
    {
        public Bai1OL()
        {
            InitializeComponent();
        }

        public bool ktTrung(ListView pList, string pValue, int pIndex)
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
            if (ktTrung(listView1, txtMa.Text, 1))
            {
                MessageBox.Show("Bị trùng", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gioi, ngoaingu = string.Empty, dantoc;
            if (rdoNam.Checked)
                gioi = "Nam";
            else
                gioi = "Nữ";
            if (chkAnh.Checked)
                ngoaingu += "Anh ";
            if (chkPhap.Checked)
                ngoaingu += "Pháp ";
            if (chkHoa.Checked)
                ngoaingu += "Hoa ";
            dantoc = comboBox1.SelectedItem.ToString();
            ListViewItem item1 = new ListViewItem(new[] { txtTen.Text, txtMa.Text, gioi, ngoaingu, dantoc });
            listView1.Items.Add(item1);
        }

        private void Bai1OL_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
            comboBox1.SelectedIndex = 0;
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
                item.SubItems[0].Text = txtTen.Text;
                item.SubItems[1].Text = txtMa.Text;
                if (rdoNam.Checked)
                    item.SubItems[2].Text = "Nam";
                else
                    item.SubItems[2].Text = "Nữ";
                string ngoaingu = string.Empty;
                if (chkAnh.Checked)
                    ngoaingu += "Anh ";
                if (chkPhap.Checked)
                    ngoaingu += "Pháp ";
                if (chkHoa.Checked)
                    ngoaingu += "Hoa ";
                item.SubItems[3].Text = ngoaingu;
                item.SubItems[4].Text = comboBox1.SelectedItem.ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTen.Text = listView1.FocusedItem.SubItems[0].Text;
            txtMa.Text = listView1.FocusedItem.SubItems[1].Text;
            if (listView1.FocusedItem.SubItems[2].Text == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            if (listView1.FocusedItem.SubItems[3].Text.Contains("Anh"))
                chkAnh.Checked = true;
            else
                chkAnh.Checked = false;
            if (listView1.FocusedItem.SubItems[3].Text.Contains("Pháp"))
                chkPhap.Checked = true;
            else
                chkPhap.Checked = false;
            if (listView1.FocusedItem.SubItems[3].Text.Contains("Hoa"))
                chkHoa.Checked = true;
            else
                chkHoa.Checked = false;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString() == listView1.FocusedItem.SubItems[4].Text)
                {
                    comboBox1.SelectedIndex = i;
                    return;
                }
            }
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnThem.PerformClick();
        }
    }
}
