using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ms = 0;

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnBatDau.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int s = Int32.Parse(txtGiay.Text);
            int m = Int32.Parse(txtPhut.Text);
            ms--;
            if (ms < 0)
            {
                ms = 59;
                s--;
                if (s < 0)
                {
                    s = 59;
                    m--;
                }
            }

            if (s < 10)
            {
                txtGiay.Text = "0" + s;
            }
            else
                txtGiay.Text = s + "";
            if (m < 10)
            {
                txtPhut.Text = "0" + m;
            }
            else
                txtPhut.Text = m + "";

            if (s == 0 && m == 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết thời gian");
                txtPhut.Text = "30";
                btnBatDau.Enabled = true;
            }
        }
    }
}
