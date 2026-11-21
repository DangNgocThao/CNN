using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNgocThao_2001206904_KT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bai1 a = new Bai1();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Control ctr=(Control)sender;
            if (int.Parse(textBox1.Text) <= 1)
                this.errorProvider1.SetError(ctr, "bạn phải nhập số > 1");
            else
                this.errorProvider1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1)
                return;
            a.N = int.Parse(textBox1.Text);
            textBox2.Text = a.XuatSNT();
            textBox3.Text = a.TongSCP().ToString();
        }
    }
}
