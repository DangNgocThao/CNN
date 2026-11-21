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
    public partial class Bai1OL : Form
    {
        public Bai1OL()
        {
            InitializeComponent();
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || ctr.Text.Length >= 10)
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
                btnGiai.PerformClick();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd1.Checked)
                label4.Enabled = txtc.Enabled = false;
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2.Checked)
            {
                label4.Enabled = txtc.Enabled = true;
                btnGiai.Enabled = false;
            }
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                if (txta.Text == string.Empty || txtb.Text == string.Empty)
                    btnGiai.Enabled = false;
                else
                    btnGiai.Enabled = true;
            }
            else
            {
                if ((txta.Text == string.Empty || txtb.Text == string.Empty || txtc.Text == string.Empty) && rd2.Checked)
                    btnGiai.Enabled = false;
                else
                    btnGiai.Enabled = true;
            }
        }

        private void Bai1OL_Load(object sender, EventArgs e)
        {
            txtc.Enabled = label4.Enabled = btnGiai.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                PhuongTrinh pt = new PhuongTrinh(a, b, 0);
                txtkq.Text = pt.GiaiPTBacNhat();
            }
            else
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                double c = double.Parse(txtc.Text);
                PhuongTrinh pt = new PhuongTrinh(a, b, c);
                txtkq.Text = pt.GiaiPTBacHai();
            }
        }
    }
}
