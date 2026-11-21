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
    public partial class BTVN : Form
    {
        Lop dt = new Lop();
        public BTVN()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == string.Empty || txtMaLop.Text == string.Empty || txtTenLop.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dt.them(txtMaLop.Text, txtTenLop.Text, txtMaKhoa.Text))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa Mã Lớp", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dt.xoa(txtMaLop.Text))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != string.Empty)
            {
                if (txtMaKhoa.Text == string.Empty && txtTenLop.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dt.sua(txtMaLop.Text, txtTenLop.Text, txtMaKhoa.Text))
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }
    }
}
