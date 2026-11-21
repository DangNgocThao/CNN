using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan7
{
    public partial class Form2 : Form
    {
        MonHoc dt = new MonHoc();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dt.them(txtMa.Text, txtTen.Text))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dt.xoa(txtMa.Text))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dt.sua(txtMa.Text, txtTen.Text))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }
    }
}
