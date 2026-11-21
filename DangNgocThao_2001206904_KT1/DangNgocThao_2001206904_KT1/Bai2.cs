using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNgocThao_2001206904_KT1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        Mang1Chieu a;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (int.Parse(txtNhap.Text) <= 1)
                this.errorProvider1.SetError(ctr, "bạn phải nhập số > 1");
            else
                this.errorProvider1.Clear();
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNhap.Text) <= 1)
                return;
            a = new Mang1Chieu(int.Parse(txtNhap.Text));
            txtDaySo.Text = a.xuat();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (txtDaySo.Text.Length == 0)
                return;
            txtSHT.Text = a.xuatSHH();
            txtMaxChan.Text = a.xuatMaxChan();
        }
    }
}
