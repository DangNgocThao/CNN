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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Bạn phải nhập số");
            else
                this.errorProvider1.Clear();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || ctr.Text.Length >= 10)
                e.Handled = true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            TinhToan kq = new TinhToan(double.Parse(txtA.Text), double.Parse(txtB.Text));
            txtKQ.Text = kq.tinhTong().ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            TinhToan kq = new TinhToan(double.Parse(txtA.Text), double.Parse(txtB.Text));
            txtKQ.Text = kq.tinhHieu().ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            TinhToan kq = new TinhToan(double.Parse(txtA.Text), double.Parse(txtB.Text));
            txtKQ.Text = kq.tinhTich().ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            TinhToan kq = new TinhToan(double.Parse(txtA.Text), double.Parse(txtB.Text));
            if(txtB.Text=="0")
            {
                MessageBox.Show("Không chia được cho 0");
                return;
            }
            txtKQ.Text = kq.tinhThuong().ToString();
        }
    }
}
