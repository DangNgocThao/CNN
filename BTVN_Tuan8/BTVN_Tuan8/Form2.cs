using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan8
{
    public partial class Form2 : Form
    {
        CSDL dl = new CSDL();
        public Form2()
        {
            InitializeComponent();
        }

        public void LoadMaSP()
        {
            List<string> mahds = dl.loadMaSP();
            foreach (string item in mahds)
            {
                cboMaSP.Items.Add(item);
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = txtSL.Enabled = cboMaSP.Enabled = cboMaSP.Enabled = btnThem.Enabled = btnHuy.Enabled = btnThanhToan.Enabled = true;
            dl.themHD();
            txtMaHD.Text = dl.layMaHDVuaThem().ToString();
            cboMaSP.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == string.Empty || txtSL.Text == string.Empty || int.Parse(txtSL.Text) <= 0 || int.Parse(txtSL.Text) > dl.laySLDau(cboMaSP.SelectedItem.ToString()))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dl.themChiTietHD(txtMaHD.Text, cboMaSP.SelectedItem.ToString(), txtSL.Text))
            {
                dl.updateSLBan(cboMaSP.SelectedItem.ToString(), txtSL.Text);
                MessageBox.Show("Thành công");
                cboMaSP.SelectedIndex = 0;
                txtSL.Clear();
                txtSL.Focus();
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dl.updateTonKho();
            LoadMaSP();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(dl.resetSLBan())
            {
                txtMaHD.Enabled = txtSL.Enabled = cboMaSP.Enabled = cboMaSP.Enabled = btnThem.Enabled = btnHuy.Enabled = btnThanhToan.Enabled = false;
                btnTao.Focus();
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dl.updateHD(txtMaHD.Text))
            {
                dl.updateTonKho();
                MessageBox.Show("Thanh toán thành công");
                txtMaHD.Enabled = txtSL.Enabled = cboMaSP.Enabled = cboMaSP.Enabled = btnThem.Enabled = btnHuy.Enabled = btnThanhToan.Enabled = false;
                btnTao.Focus();
            }
            else
                MessageBox.Show("Thanh toán thất bại");
        }
    }
}
