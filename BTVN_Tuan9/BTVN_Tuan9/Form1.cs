using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan9
{
    public partial class Form1 : Form
    {
        CSDL dl = new CSDL();
        public Form1()
        {
            InitializeComponent();
        }
        public void loadSV()
        {
            cboSV.DataSource = dl.LoadSinhVien();
            cboSV.DisplayMember = "HoTen";
            cboSV.ValueMember = "MaSinhVien";
        }
        public void loadMH()
        {
            cboMH.DataSource = dl.LoadMonHoc();
            cboMH.DisplayMember = "TenMonHoc";
            cboMH.ValueMember = "MaMonHoc";
        }
        public void loadDGV()
        {
            DataTable kq = dl.LoadFullDiem();
            Bingding(kq);
            dataGridView1.DataSource = kq;
            dl.LoadDiem();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSV();
            loadMH();
            loadDGV();
        }
        public void Bingding(DataTable pData)
        {
            txtDiem.DataBindings.Clear();
            cboSV.DataBindings.Clear();
            cboMH.DataBindings.Clear();

            txtDiem.DataBindings.Add("text", pData, "Diem");
            cboSV.DataBindings.Add("text", pData, "HoTen");
            cboMH.DataBindings.Add("text", pData, "TenMonHoc");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtDiem.Text);
            if (t < 0 || t > 10)
            {
                MessageBox.Show("Điểm nhập sai");
                return;
            }
            if (dl.ThemDiem(cboSV.SelectedValue.ToString(), cboMH.SelectedValue.ToString(), txtDiem.Text))
            {
                MessageBox.Show("Thêm thành công");
                loadDGV();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dl.XoaDiem(cboSV.SelectedValue.ToString(), cboMH.SelectedValue.ToString()))
            {
                MessageBox.Show("Xóa thành công");
                loadDGV();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtDiem.Text);
            if (t < 0 || t > 10)
            {
                MessageBox.Show("Điểm nhập sai");
                return;
            }
            if (dl.SuaDiem(cboSV.SelectedValue.ToString(), cboMH.SelectedValue.ToString(), txtDiem.Text))
            {
                MessageBox.Show("sửa thành công");
                loadDGV();
            }
            else
                MessageBox.Show("sửa thất bại");
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cboSV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dl.LoadDiemTheoSV(cboSV.SelectedValue.ToString());
        }

        private void cboMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dl.LoadDiemTheoMH(cboMH.SelectedValue.ToString());
        }
    }
}
