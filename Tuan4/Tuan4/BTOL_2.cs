using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan4
{
    public partial class BTOL_2 : Form
    {
        public BTOL_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_nhapMang.Clear();
            btn_nhapMang.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_tong_Click(object sender, EventArgs e)
        {

        }

        private void BTOL_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_nhapMang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_nhapMang_Click(object sender, EventArgs e)
        {
            if (txt_nhapMang.Text == string.Empty)
                btn_nhapMang.Enabled = false;
            else
            { 
                txt_nhapMang.Text += ' ';
            }
        }

        private void BTOL_2_Load(object sender, EventArgs e)
        {
            btn_nhapMang.Enabled = false;
            txt_ketQua.Enabled = false;
            txt_ketQua.BackColor = Color.White;
        }

        private void txt_nhapMang_TextChanged(object sender, EventArgs e)
        {
            if (txt_nhapMang.Text.Length > 0)
                btn_nhapMang.Enabled = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
