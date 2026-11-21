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
    public partial class Form1 : Form
    {
        CSDL dl = new CSDL();
        public Form1()
        {
            InitializeComponent();
        }

        public void loadLop()
        {
            cboLop.DataSource = dl.LoadLop();
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
        }

        public void loadSV()
        {
            dataGridView1.DataSource = dl.LoadSV();
        }

        public void enableTxt(bool t)
        {
            txtMaSV.Enabled = txtHoTen.Enabled = dateTimePicker1.Enabled = cboLop.Enabled = t;
        }

        public void bingDing(DataTable pData)
        {
            txtMaSV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            cboLop.DataBindings.Clear();

            txtMaSV.DataBindings.Add("text",pData,"MaSinhVien");
            txtHoTen.DataBindings.Add("text", pData, "HoTen");
            dateTimePicker1.DataBindings.Add("value", pData, "NgaySinh");
            cboLop.DataBindings.Add("SelectedValue", pData, "MaLop");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLop();
            loadSV();
            enableTxt(false);
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            bingDing(dl.LoadSV());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].ReadOnly = true;
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dataGridView1.ReadOnly = false;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].ReadOnly = false;
            }
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dl.LuuSV();
            bingDing(dl.LoadSV());
            MessageBox.Show("Thành công");
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.No)
                return;
            string MaSV = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (dl.xoaSV(MaSV))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }
    }
}
