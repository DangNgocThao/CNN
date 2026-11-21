namespace BTVN_Tuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tong = 0;
        int soLuot = 0;

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTen.Text == string.Empty || txtDiaChi.Text == string.Empty || txtSoNgayO.Text == string.Empty)
                btnThanhToan.Enabled = false;
            else
                btnThanhToan.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            btnNhapMoi.Enabled = btnTongKet.Enabled = true;
            int soNgay=int.Parse(txtSoNgayO.Text);
            double thanhTien = 0;
            if (rdoPDon.Checked)
                thanhTien += 300000 * soNgay;
            if (rdoPDoi.Checked)
                thanhTien += 350000 * soNgay;
            if (rdoBa.Checked)
                thanhTien += 400000 * soNgay;
            if (chkTivi.Checked)
                thanhTien += 10000;
            if (chkNet.Checked)
                thanhTien += 10000;
            if (chkMNcNong.Checked)
                thanhTien += 10000;
            if (chkKaraoke.Checked)
                thanhTien += 50000;
            if (chkAnSang.Checked)
                thanhTien += 15000 * soNgay;
            txtThanhTien.Text = thanhTien.ToString() + " VNĐ";
            tong += thanhTien;
            soLuot++;
            btnThanhToan.Enabled = false;
        }

        private void txtSoNgayO_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || ctr.Text.Length >= 3)
                e.Handled = true;
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = txtDiaChi.Text = txtSoNgayO.Text = txtThanhTien.Text = txtSoLuot.Text = txtTongSoTien.Text = string.Empty;
            chkTivi.Checked = chkNet.Checked = chkMNcNong.Checked = chkKaraoke.Checked = chkAnSang.Checked = false;
            rdoPDon.Checked = true;
            btnNhapMoi.Enabled = false;
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            txtSoLuot.Text = soLuot.ToString();
            txtTongSoTien.Text = tong.ToString() + " VNĐ";
            btnTongKet.Enabled = false;
            tong = 0;
            soLuot = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}