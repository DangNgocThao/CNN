using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            if (lst_Trai.SelectedItem != null)
            {
                lst_Phai.Items.Add(lst_Trai.SelectedItem);
                lst_Trai.Items.Remove(lst_Trai.SelectedItem);
            }
        }

        private void btnQuaPhaiAll_Click(object sender, EventArgs e)
        {
            lst_Phai.Items.AddRange(lst_Trai.Items);
            lst_Trai.Items.Clear();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            if (lst_Phai.SelectedItem != null)
            {
                lst_Trai.Items.Add(lst_Phai.SelectedItem);
                lst_Phai.Items.Remove(lst_Phai.SelectedItem);
            }
        }

        private void btnQuaTraiAll_Click(object sender, EventArgs e)
        {
            lst_Trai.Items.AddRange(lst_Phai.Items);
            lst_Phai.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] list = { "Cốc", "Ổi", "Xoài", "Me", "Bưởi", "Cam" };
            lst_Trai.Items.AddRange(list);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ko?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
