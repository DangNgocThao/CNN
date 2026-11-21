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
    public partial class Bai2OL : Form
    {
        public Bai2OL()
        {
            InitializeComponent();
        }
        double Tong = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text=="Thêm")
            {
                if(txtDiaChi.Text==string.Empty||txtSoTien.Text==string.Empty||txtTen.Text==string.Empty||txtSoTK.Text==string.Empty)
                {
                    MessageBox.Show("Thông tin chưa đầy đủ", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string stt = (listView1.Items.Count + 1).ToString();
                ListViewItem item = new ListViewItem(new[] { stt, txtSoTK.Text, txtTen.Text, txtDiaChi.Text, txtSoTien.Text });
                listView1.Items.Add(item);
                btnLuu.Enabled = true;
                btnThem.Text = "Hủy";
                Tong += double.Parse(txtSoTien.Text);
                txtTong.Text = Tong.ToString();
            }
            else
            {
                listView1.Items.RemoveAt(listView1.Items.Count - 1);
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                Tong -= double.Parse(txtSoTien.Text);
                txtTong.Text = Tong.ToString();
                txtDiaChi.Clear();
                txtSoTien.Clear();
                txtSoTK.Clear();
                txtTen.Clear();
                txtSoTK.Focus();
            }
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
                btnXoa.Enabled = true;
            else
                btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Text = "Thêm";
            txtDiaChi.Clear();
            txtSoTien.Clear();
            txtSoTK.Clear();
            txtTen.Clear();
            txtSoTK.Focus();
            btnLuu.Enabled = false;
        }
        public void updateSTT()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.Remove();
                Tong -= double.Parse(item.SubItems[4].Text);
                txtTong.Text = Tong.ToString();
                updateSTT();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
