using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BaiMau
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void txta_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
                errorProvider1.SetError(ctr, "Bạn chưa nhập số");
            else
                errorProvider1.SetError(ctr, string.Empty);
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || ctr.Text.Length >= 10)
                e.Handled = true;
        }

        private void Bai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            if (txta.Text.Length == 0 || txtb.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UCLN_BCNN kq = new UCLN_BCNN(int.Parse(txta.Text), int.Parse(txtb.Text));
            txtUCLN.Text = kq.UCLN().ToString();
            txtBCNN.Text = kq.BCNN().ToString();
        }

        private void txta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTH.PerformClick();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
            txta.Focus();
        }
    }
}
