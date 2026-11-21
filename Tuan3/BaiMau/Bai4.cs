using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiMau
{
    public partial class Bai4 : Form
    {
        Mang1C a = new Mang1C();
        public Bai4()
        {
            InitializeComponent();
        }

        private void txtNhap_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
                errorProvider1.SetError(ctr, "Bạn chưa nhập số");
            else
                errorProvider1.SetError(ctr, string.Empty);
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || ctr.Text.Length >= 3)
                e.Handled = true;
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnNhap.PerformClick();
        }

        private void Bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            a.Nhap(int.Parse(txtNhap.Text));
            txtXuat.Text = a.Xuat();
            txtTong.Text = a.Tong().ToString();
            txtTongChan.Text = a.TongChan().ToString();
            txtTongLe.Text = a.TongLe().ToString();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            a.Clear();
            txtNhap.Clear();
            txtXuat.Clear();
            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtNhap.Focus();
        }
    }
}
