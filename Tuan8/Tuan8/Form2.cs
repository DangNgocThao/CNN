using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan8
{
    public partial class Form2 : Form
    {
        Lop dt = new Lop();
        public Form2()
        {
            InitializeComponent();
        }

        public void LoadKhoa()
        {
            List<string> makhoas = dt.LoadMaKhoa();
            foreach (string item in makhoas)
            {
                cboKhoa.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int kq = dt.ktTrung(txtMa.Text);
            if (kq == -1)
            {
                MessageBox.Show("Lỗi câu lệnh");
                return;
            }
            if (kq == 1)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            if (dt.them(txtMa.Text, txtTen.Text, cboKhoa.SelectedItem.ToString()))
            {
                MessageBox.Show("Thành công");
                button1.PerformClick();
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            cboKhoa.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<string> ds = dt.LoadMaLop();
            if (ds.IndexOf(txtMa.Text)==-1)
            {
                MessageBox.Show("Mã lớp không tồn tại");
                return;
            }
            if (dt.xoa(txtMa.Text))
            {
                MessageBox.Show("Thành công");
                button1.PerformClick();
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            List<string> ds = dt.LoadMaLop();
            if (ds.IndexOf(txtMa.Text) == -1)
            {
                MessageBox.Show("Mã lớp không tồn tại");
                return;
            }
            if (dt.sua(txtMa.Text, txtTen.Text, cboKhoa.SelectedItem.ToString()))
            {
                MessageBox.Show("Thành công");
                button1.PerformClick();
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<lop_khoa> dl = dt.ListLopKhoa();
            foreach (lop_khoa item in dl)
            {
                ListViewItem item1 = new ListViewItem(new[] { item.MaLop, item.TenLop, item.MaKhoa });
                listView1.Items.Add(item1);
            }
        }
    }
}
