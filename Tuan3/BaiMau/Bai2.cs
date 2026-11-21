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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void txtTDN_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Bạn phải nhận số");
            else
                this.errorProvider1.Clear();
        }

        private void txtDCE_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Contains("@gmail.com") == false)
                errorProvider1.SetError(ctr, "Email không hợp lệ");
            else
                errorProvider1.Clear();
        }

        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (txtTDN.Text.Length == 0 || txtDCE.Text.Length == 0 || txtMK.Text.Length == 0 || txtXNMK.Text.Length == 0 || txtMK.Text != txtXNMK.Text || txtDCE.Text.Contains("@gmail.com") == false)
            {
                MessageBox.Show("Dữ liệu thiếu hoặc sai");
                return;
            }
            MessageBox.Show("Tên đăng nhập: " + txtTDN.Text + "\n" + "Địa chỉ email: " + txtDCE.Text + "\n" + "Mật khẩu: " + txtMK.Text);
        }

        private void txtXNMK_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text != txtMK.Text)
                errorProvider1.SetError(ctr, "Mật khẩu không khớp");
            else
                errorProvider1.Clear();
        }

        private void txtTDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDK.PerformClick();
        }

    }
}
