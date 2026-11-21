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
    public partial class Form1 : Form
    {
        Khoa dt = new Khoa();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = dt.ktTrung(txtMa.Text);
            if(kq==-1)
            {
                MessageBox.Show("Lỗi câu lệnh");
                return;
            }
            if (kq == 1)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            if (dt.them(txtMa.Text, txtTen.Text))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> ds = dt.LoadMaKhoa();
            if (ds.IndexOf(txtMa.Text) == -1)
            {
                MessageBox.Show("Mã khoa không tồn tại");
                return;
            }
            if (dt.xoa(txtMa.Text))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> ds = dt.LoadMaKhoa();
            if (ds.IndexOf(txtMa.Text) == -1)
            {
                MessageBox.Show("Mã khoa không tồn tại");
                return;
            }
            if (dt.sua(txtMa.Text, txtTen.Text))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }
    }
}