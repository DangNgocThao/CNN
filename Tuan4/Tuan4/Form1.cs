using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            string s = "Kết quả là: ";
            if (txta.Text.Length == 0 || txtb.Text.Length == 0)
            {
                MessageBox.Show("Ban chưa nhập a hoặc b!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            TinhToan dt = new TinhToan(a, b);
            if (chkcong.Checked)
                txtkq.Text = s + a + " + " + b + " = " + dt.Cong();
            else if (chktru.Checked)
                txtkq.Text = s + a + " - " + b + " = " + dt.Tru();
            else if (chknhan.Checked)
                txtkq.Text = s + a + " * " + b + " = " + dt.Nhan();
            else if (b != 0)
                txtkq.Text = s + a + " / " + b + " = " + dt.Chia();
            else
                MessageBox.Show("Phép chia bị lỗi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))||ctr.Text.Length >= 10)
                e.Handled = true;
        }

        private void txta_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Bạn phải nhập số");
            else
                this.errorProvider1.Clear();
        }

        private void txta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntinh.PerformClick();
        }
    }
}
