using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan10
{
    public partial class Form1 : Form
    {
        CSDL dl = new CSDL();
        public Form1()
        {
            InitializeComponent();
        }

        public void loadKhoa()
        {
            DataTable kq = dl.loadKhoa();
            dataGridView1.DataSource = kq;
            Bingding(kq);
        }

        public void Bingding(DataTable pData)
        {
            txtMa.DataBindings.Clear();
            txtTen.DataBindings.Clear();

            txtMa.DataBindings.Add("text", pData, "MaKhoa");
            txtTen.DataBindings.Add("text", pData, "TenKhoa");
        }

        public void enableTxt(bool kt)
        {
            txtTen.Enabled = txtMa.Enabled = kt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enableTxt(true);
            btnLuu.Enabled = true;
            txtMa.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadKhoa();
            enableTxt(false);
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            if (txtMa.Enabled)
                dl.themKhoa(txtMa.Text, txtTen.Text);
            else
                dl.suaKhoa(txtMa.Text, txtTen.Text);
            if (dl.luuKhoa())
            {
                MessageBox.Show("Thành công");
                Bingding(dl.loadKhoa());
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("bạn có muốn xóa không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                dl.xoaKhoa(txtMa.Text);
            else
                return;
            if (dl.luuKhoa())
            {
                MessageBox.Show("Thành công");
                Bingding(dl.loadKhoa());
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            enableTxt(true);
            txtMa.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
