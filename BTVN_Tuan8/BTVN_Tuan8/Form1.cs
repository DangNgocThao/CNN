using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan8
{
    public partial class Form1 : Form
    {
        CSDL dl = new CSDL();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dl.themSP(txtTenSP.Text))
            {
                MessageBox.Show("Thành công");
                dl.themTonKho(txtTenSP.Text);
            }
            else
                MessageBox.Show("Thất bại");
        }
    }
}
