using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };
            foreach (string s in pb)
            {
                trv_DS.Nodes.Add(s);
                cbo_phongban.Items.Add(s);
            }
            cbo_phongban.SelectedIndex = 0;
        }

        private void btn_ThemPB_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_phongban.Text))
            {
                trv_DS.Nodes.Add(txt_phongban.Text);
                cbo_phongban.Items.Add(txt_phongban.Text);
            }
            else
                MessageBox.Show("Phòng ban đã tồn tại!");
            txt_phongban.Text = "";
            txt_phongban.Focus();
        }
        public bool kiemtra(string s)
        {
            for (int i = 0; i < cbo_phongban.Items.Count; i++)
            {
                if (s == cbo_phongban.Items[i].ToString())
                    return false;
            }
            return true;
        }
        private void btn_XoaPB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (trv_DS.SelectedNode != null)
                {
                    cbo_phongban.Items.Remove(trv_DS.SelectedNode.Text);
                    trv_DS.Nodes.Remove(trv_DS.SelectedNode);
                }
            }
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in trv_DS.Nodes)
                if (node.Text == cbo_phongban.Text)
                {
                    index = node.Index;
                    break;
                }
            trv_DS.Nodes[index].Nodes.Add(txt_hoten.Text + "(" + txt_maso.Text + ")");
            trv_DS.ExpandAll();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ko?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = false;
        }
    }
}
