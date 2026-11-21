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
    public partial class Form2 : Form
    {
        Data dl = new Data();
        public Form2()
        {
            InitializeComponent();
        }

        public void loadLopKhoa()
        {
            DataTable kq = dl.LoadLopKhoa();
            cboLop.DataSource = kq;
            cboLop.ValueMember = "TenLop";
            cboLop.DisplayMember = "TenLop";
            cboKhoa.DataSource = kq;
            cboKhoa.ValueMember = "TenLop";
            cboKhoa.DisplayMember = "TenKhoa";
        }

        public void loadSV()
        {
            dataGridView1.DataSource = dl.LoadSV();
        }

        public void enableTxt(bool t)
        {
            txtMaSV.Enabled = txtHoTen.Enabled = dateTimePicker1.Enabled = cboLop.Enabled = cboKhoa.Enabled = t;
        }

        public void bingDing(DataTable pData)
        {
            txtMaSV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            cboLop.DataBindings.Clear();
            cboKhoa.DataBindings.Clear();

            txtMaSV.DataBindings.Add("text", pData, "MaSinhVien");
            txtHoTen.DataBindings.Add("text", pData, "HoTen");
            dateTimePicker1.DataBindings.Add("value", pData, "NgaySinh");
            cboLop.DataBindings.Add("SelectedValue", pData, "TenLop");
            cboKhoa.DataBindings.Add("SelectedValue", pData, "TenLop");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadLopKhoa();
            loadSV();
            //enableTxt(false);
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
            bingDing(dl.LoadSV());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bingDing(dl.LoadSV());
            MessageBox.Show("Thành công");
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                return;
        }
    }
}
