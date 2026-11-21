using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan9
{
    public partial class Form2 : Form
    {
        CSDL dt = new CSDL();
        public Form2()
        {
            InitializeComponent();
        }

        public void loadDTGV()
        {
            DataTable kq=dt.LoadKhoa();
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dt.themKhoa(txtMa.Text, txtTen.Text))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadDTGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dt.xoaKhoa(txtMa.Text))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dt.suaKhoa(txtMa.Text, txtTen.Text))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
        }
    }
}
