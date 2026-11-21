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
    public partial class Form1 : Form
    {
        CSDL dt = new CSDL();
        public Form1()
        {
            InitializeComponent();
        }

        public void loadKhoa()
        {
            cboKhoa.DataSource = dt.LoadKhoa();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }
        public void loadDTGV()
        {
            //DataTable kq = dt.LoadLop();
            //dataGridView1.DataSource = kq;
            //Bingding(kq);
            dataGridView1.DataSource = dt.LoadLopKhoa();
            dt.LoadLop();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadKhoa();
            loadDTGV();
        }

        public void Bingding(DataTable pData)
        {
            txtMa.DataBindings.Clear();
            txtTen.DataBindings.Clear();

            txtMa.DataBindings.Add("text", pData, "MaLop");
            txtTen.DataBindings.Add("text", pData, "TenLop");
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cboKhoa.SelectedValue.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dt.ThemLop(txtMa.Text, txtTen.Text, cboKhoa.SelectedValue.ToString()))
            {
                MessageBox.Show("Thêm thành công");
                loadDTGV();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dt.XoaLop(txtMa.Text))
            {
                MessageBox.Show("Xóa thành công");
                loadDTGV();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dt.SuaLop(txtMa.Text, txtTen.Text, cboKhoa.SelectedValue.ToString()))
            {
                MessageBox.Show("Thêm thành công");
                loadDTGV();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }


    }
}
