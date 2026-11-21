using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan11
{
    public partial class Form2 : Form
    {
        Data dl = new Data();
        public Form2()
        {
            InitializeComponent();
        }

        public void loadSV()
        {
            cboTenSV.DataSource=dl.LoadSV();
            cboTenSV.DisplayMember = "HoTen";
            cboTenSV.ValueMember = "MaSinhVien";
        }
        public void loadMH()
        {
            cboMH.DataSource = dl.LoadMH();
            cboMH.DisplayMember = "TenMonHoc";
            cboMH.ValueMember = "MaMonHoc";
        }
        public void loadDiem()
        {
            dataGridView1.DataSource = dl.LoadDiem();
        }
        public void enableTxt(bool t)
        {
            cboTenSV.Enabled = cboMH.Enabled = txtDiem.Enabled = t;
        }
        public void bingDing(DataTable pDT)
        {
            cboTenSV.DataBindings.Clear();
            cboMH.DataBindings.Clear();
            txtDiem.DataBindings.Clear();

            cboTenSV.DataBindings.Add("SelectedValue", pDT, "MaSinhVien");
            cboMH.DataBindings.Add("SelectedValue", pDT, "MaMonHoc");
            txtDiem.DataBindings.Add("text",pDT,"Diem");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadSV();
            loadMH();
            loadDiem();
            enableTxt(false);
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            bingDing(dl.LoadDiem());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].ReadOnly = true;
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dataGridView1.ReadOnly = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].ReadOnly = false;
            }
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dl.LuuDiem();
            bingDing(dl.LoadDiem());
            MessageBox.Show("Thành công");
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                return;
            string MaSV = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string MaMH = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dl.xoaDiem(MaSV, MaMH))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }
    }
}
