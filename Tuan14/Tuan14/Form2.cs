using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan14
{
    public partial class Form2 : Form
    {
        CSDL dl = new CSDL();
        public Form2()
        {
            InitializeComponent();
        }

        public void loadCoSo()
        {
            cboCoSo.DataSource = dl.loadCoSo();
            cboCoSo.DisplayMember = "TENCOSO";
            cboCoSo.ValueMember = "MACOSO";
        }

        public void loadDonVi()
        {
            CboDonVi.DataSource = dl.loadDonVi();
            CboDonVi.DisplayMember = "TENDONVI";
            CboDonVi.ValueMember = "MADONVI";
        }

        public void loadView()
        {
            dataGridView1.DataSource = dl.loadView();
            dataGridView1.Columns[2].Visible = dataGridView1.Columns[3].Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadCoSo();
            loadDonVi();
            loadView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void xóaGVĐangChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa giáo viên: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " khỏi cơ sở dữ liệu?", "Xóa giáo viên?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dl.xoaGV(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                MessageBox.Show("Xóa thành công");
            }
            else
                MessageBox.Show("Xóa thất bại");
        }
    }
}
