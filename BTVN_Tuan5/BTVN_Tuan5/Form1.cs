namespace BTVN_Tuan5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TuDien> ds;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void themDuLieu()
        {
            ds.Add(new TuDien("student", "Sinh Viên, Học Sinh"));
            ds.Add(new TuDien("teacher", "Giáo Viên, Giảng Viên"));
            ds.Add(new TuDien("worker", "Công Nhân"));
            ds.Add(new TuDien("hat", "Mũ"));
            ds.Add(new TuDien("head", "Đầu"));
            ds.Add(new TuDien("mouse", "Con Chuột"));
            ds.Add(new TuDien("cat", "Con Mèo"));
            ds.Add(new TuDien("dog", "Con Chó"));
            ds.Add(new TuDien("snake", "Con Rắn"));
            ds.Add(new TuDien("loan", "Tiền Vay"));
            ds.Add(new TuDien("frog", "Con Ếch"));
            ds.Add(new TuDien("sheep", "Con Cừu"));
        }

        void ThemVaoCombobox()
        {
            foreach (TuDien item in ds)
            {
                cboTA.Items.Add(item.Anh);
                cboTV.Items.Add(item.Viet);
            }
        }

        void xuatTV()
        {
            foreach (TuDien item in ds)
            {
                if (cboTA.SelectedItem.ToString() == item.Anh.ToString())
                    txtTV.Text = item.Viet.ToString();
            }
        }

        void xuatTA()
        {
            foreach (TuDien item in ds)
            {
                if(cboTV.SelectedItem.ToString() == item.Viet.ToString())
                    txtTA.Text = item.Anh.ToString();
            }
        }

        void autoAnh()
        {
            string[] s = new string[cboTA.Items.Count];
            for (int i = 0; i < cboTA.Items.Count; i++)
                s[i] = cboTA.Items[i].ToString();
            cboTA.AutoCompleteMode = AutoCompleteMode.Append;
            cboTA.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboTA.AutoCompleteCustomSource.AddRange(s);
        }

        void autoViet()
        {
            string[] s = new string[cboTV.Items.Count];
            for (int i = 0; i < cboTV.Items.Count; i++)
                s[i] = cboTV.Items[i].ToString();
            cboTV.AutoCompleteMode = AutoCompleteMode.Append;
            cboTV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboTV.AutoCompleteCustomSource.AddRange(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new List<TuDien>();
            themDuLieu();
            ThemVaoCombobox();
            autoAnh();
            autoViet();
        }

        private void cboTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cboTA.SelectedIndex >= 0)
                xuatTV();
        }

        private void cboTA_Click(object sender, EventArgs e)
        {
            if (cboTA.SelectedIndex >= 0)
                xuatTV();
        }

        private void cboTV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && cboTV.SelectedIndex >= 0)
                xuatTA();
        }

        private void cboTV_Click(object sender, EventArgs e)
        {
            if (cboTV.SelectedIndex >= 0)
                xuatTA();
        }

        private void cboTA_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cboTA.Items.Count; i++)
                if (cboTA.Text == cboTA.Items[i].ToString())
                    cboTA.SelectedIndex = i;
        }

        private void cboTV_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cboTV.Items.Count; i++)
                if (cboTV.Text == cboTV.Items[i].ToString())
                    cboTV.SelectedIndex = i;
        }
    }
}