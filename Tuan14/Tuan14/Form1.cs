using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan14
{
    public partial class Form1 : Form
    {
        KetNoi dl = new KetNoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKetNot_Click(object sender, EventArgs e)
        {
            if (txtTenM.Text == string.Empty || txtTenCSDL.Text == string.Empty || txtUser.Text == string.Empty || txtPass.Text==string.Empty)
            {
                MessageBox.Show("Không điền đầy đủ thông tin");
                return;
            }
            if (dl.ktKetNoi(txtTenM.Text, txtTenCSDL.Text, txtUser.Text, txtPass.Text))
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kết nối thất bại");
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKetNot.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPass.Select();
        }

    }
}
