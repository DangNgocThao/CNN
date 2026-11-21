using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan12
{
    public partial class Form2 : Form
    {
        CDSL dl = new CDSL();
        public Form2()
        {
            InitializeComponent();
        }
        public void loadLop()
        {
            cboLop.DataSource = dl.loadLop();
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadLop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pmalop = cboLop.SelectedValue.ToString();
            DataTable dt = dl.loadSV(pmalop);
            CrystalReport3 cr = new CrystalReport3();
            cr.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
