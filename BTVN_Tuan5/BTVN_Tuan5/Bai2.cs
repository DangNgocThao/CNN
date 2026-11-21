using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan5
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        bool ktLap(string value)
        {
            return lstNhap.Items.Contains(value);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lstNhap.ClearSelected();
            if (txtNhap.Text == string.Empty)
                return;
            if (!ktLap(txtNhap.Text))
            {
                lstNhap.Items.Add(txtNhap.Text);
                txtNhap.Clear();
            }
            else MessageBox.Show("Phần tử đã có trong ListBox", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (lstNhap.Items.Count == 0)
                return;
            int tong = 0;
            for (int i = 0; i < lstNhap.Items.Count; i++)
                tong += int.Parse(lstNhap.Items[i].ToString());
            MessageBox.Show("Tổng các phần tử trong List: " + tong, "Tổng", MessageBoxButtons.OK);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstNhap.Items.Count == 0)
                return;
            if (lstNhap.Items.Count == 1)
            {
                lstNhap.Items.RemoveAt(0);
                return;
            }
            lstNhap.Items.RemoveAt(lstNhap.Items.Count - 1);
            lstNhap.Items.RemoveAt(0);
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lstNhap.SelectedItem == null)
                return;
            for (int i = lstNhap.Items.Count - 1; i >= 0; i--)
                if (lstNhap.GetSelected(i))
                    lstNhap.Items.RemoveAt(i);
        }

        private void btnTangHai_Click(object sender, EventArgs e)
        {
            if (lstNhap.Items.Count == 0)
                return;
            for (int i = 0; i < lstNhap.Items.Count; i++)
                lstNhap.Items[i] = (int.Parse(lstNhap.Items[i].ToString()) + 2).ToString();
        }

        private void btnThayBinhPhuong_Click(object sender, EventArgs e)
        {
            if (lstNhap.Items.Count == 0)
                return;
            for (int i = 0; i < lstNhap.Items.Count; i++)
                lstNhap.Items[i] = Math.Pow((double)int.Parse(lstNhap.Items[i].ToString()), 2).ToString();
        }

        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            lstNhap.ClearSelected();
            if (lstNhap.Items.Count == 0)
                return;
            for (int i = 0; i < lstNhap.Items.Count; i++)
                if (int.Parse(lstNhap.Items[i].ToString()) % 2 == 0)
                {
                    lstNhap.SetSelected(i, true);
                    break;
                }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            lstNhap.ClearSelected();
            if (lstNhap.Items.Count == 0)
                return;
            for (int i = 0; i < lstNhap.Items.Count; i++)
                if (int.Parse(lstNhap.Items[i].ToString()) % 2 == 1)
                {
                    lstNhap.SetSelected(i, true);
                    break;
                }
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNhap.Text == string.Empty)
                return;
            if (e.KeyCode == Keys.Enter)
                btnNhap.PerformClick();
        }
    }
}
