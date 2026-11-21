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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void checkR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkR.Checked == true)
                label1.Font = new Font(label1.Font, FontStyle.Regular);
        }

        private void checkB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB.Checked == true)
                label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void checkI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkI.Checked == true)
                label1.Font = new Font(label1.Font, FontStyle.Italic);
        }

        private void checkBaI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBaI.Checked == true)
                label1.Font = new Font(label1.Font, (FontStyle)(FontStyle.Bold | FontStyle.Italic));
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRed.Checked == true)
                label1.ForeColor = Color.Red;
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGreen.Checked == true)
                label1.ForeColor = Color.Green;
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlue.Checked == true)
                label1.ForeColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioAuto_CheckedChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(0, 3);
            if (radioAuto.Checked)
                if (a == 0)
                    label1.ForeColor = Color.Red;
                else if (a == 1)
                    label1.ForeColor = Color.Green;
                else if (a == 2)
                    label1.ForeColor = Color.Green;
        }
    }
}
