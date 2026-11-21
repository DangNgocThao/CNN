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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked||checkBox2.Checked||checkBox3.Checked||checkBox4.Checked)
            { 
            double t=0;
            if (checkBox1.Checked)
                t += 50000;
            if (checkBox2.Checked)
                t += 30000;
            if (checkBox3.Checked)
                t += 35000;
            if (checkBox4.Checked)
                t += 28000;
            if (radioButton1.Checked)
                t = t * 90 / 100;
            textBox1.Text = t.ToString();
            }
        }
    }
}
