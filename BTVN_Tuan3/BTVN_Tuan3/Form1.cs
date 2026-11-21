namespace BTVN_Tuan3
{
    public partial class Form1 : Form
    {
        static double a, b;
        string pheptinh;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtShow.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtShow.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtShow.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtShow.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtShow.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtShow.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtShow.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtShow.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtShow.Text += "9";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            pheptinh = "+";
            a = double.Parse(txtShow.Text);
            txtShow.Clear();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            pheptinh = "-";
            a = double.Parse(txtShow.Text);
            txtShow.Clear();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            pheptinh = "*";
            a = double.Parse(txtShow.Text);
            txtShow.Clear();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            pheptinh = "/";
            a = double.Parse(txtShow.Text);
            txtShow.Clear();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            double kq;
            b = double.Parse(txtShow.Text);
            switch (pheptinh)
            {
                case "+":
                    kq = a + b;
                    txtShow.Text = kq.ToString();
                    break;
                case "-":
                    kq = a - b;
                    txtShow.Text = kq.ToString();
                    break;
                case "*":
                    kq = a * b;
                    txtShow.Text = kq.ToString();
                    break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("Không chia được cho 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    kq = a / b;
                    txtShow.Text = kq.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            a = b = 0;
            pheptinh = String.Empty;
            txtShow.Clear();
        }

        private void txtShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtShow.Text += "0";
        }
    }
}