namespace BTVN_Tuan5
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstNhap = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.btnThayBinhPhuong = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnTangHai = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnKT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstNhap);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(51, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(127, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listbox";
            // 
            // lstNhap
            // 
            this.lstNhap.FormattingEnabled = true;
            this.lstNhap.ItemHeight = 15;
            this.lstNhap.Location = new System.Drawing.Point(7, 86);
            this.lstNhap.Name = "lstNhap";
            this.lstNhap.Size = new System.Drawing.Size(113, 169);
            this.lstNhap.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(7, 52);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(113, 30);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(7, 22);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(113, 23);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChonSoLe);
            this.groupBox2.Controls.Add(this.btnThayBinhPhuong);
            this.groupBox2.Controls.Add(this.btnChonSoChan);
            this.groupBox2.Controls.Add(this.btnXoaChon);
            this.groupBox2.Controls.Add(this.btnTangHai);
            this.groupBox2.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox2.Controls.Add(this.btnTong);
            this.groupBox2.Location = new System.Drawing.Point(186, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(187, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử Lý Listbox";
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.Location = new System.Drawing.Point(7, 223);
            this.btnChonSoLe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(173, 27);
            this.btnChonSoLe.TabIndex = 6;
            this.btnChonSoLe.Text = "Chọn số lẻ";
            this.btnChonSoLe.UseVisualStyleBackColor = true;
            this.btnChonSoLe.Click += new System.EventHandler(this.btnChonSoLe_Click);
            // 
            // btnThayBinhPhuong
            // 
            this.btnThayBinhPhuong.Location = new System.Drawing.Point(7, 156);
            this.btnThayBinhPhuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThayBinhPhuong.Name = "btnThayBinhPhuong";
            this.btnThayBinhPhuong.Size = new System.Drawing.Size(173, 27);
            this.btnThayBinhPhuong.TabIndex = 5;
            this.btnThayBinhPhuong.Text = "Thay bằng bình phương";
            this.btnThayBinhPhuong.UseVisualStyleBackColor = true;
            this.btnThayBinhPhuong.Click += new System.EventHandler(this.btnThayBinhPhuong_Click);
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.Location = new System.Drawing.Point(7, 189);
            this.btnChonSoChan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(173, 27);
            this.btnChonSoChan.TabIndex = 4;
            this.btnChonSoChan.Text = "Chọn số chẵn";
            this.btnChonSoChan.UseVisualStyleBackColor = true;
            this.btnChonSoChan.Click += new System.EventHandler(this.btnChonSoChan_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(7, 89);
            this.btnXoaChon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(173, 27);
            this.btnXoaChon.TabIndex = 3;
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnTangHai
            // 
            this.btnTangHai.Location = new System.Drawing.Point(7, 122);
            this.btnTangHai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTangHai.Name = "btnTangHai";
            this.btnTangHai.Size = new System.Drawing.Size(173, 27);
            this.btnTangHai.TabIndex = 2;
            this.btnTangHai.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangHai.UseVisualStyleBackColor = true;
            this.btnTangHai.Click += new System.EventHandler(this.btnTangHai_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(7, 55);
            this.btnXoaDauCuoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(173, 27);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(7, 22);
            this.btnTong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(173, 27);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng các phần tử trong List";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnKT
            // 
            this.btnKT.Location = new System.Drawing.Point(51, 335);
            this.btnKT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKT.Name = "btnKT";
            this.btnKT.Size = new System.Drawing.Size(322, 27);
            this.btnKT.TabIndex = 3;
            this.btnKT.Text = "KẾT THÚC";
            this.btnKT.UseVisualStyleBackColor = true;
            this.btnKT.Click += new System.EventHandler(this.btnKT_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 61);
            this.panel1.TabIndex = 4;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnThayBinhPhuong;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnTangHai;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnKT;
        private System.Windows.Forms.Panel panel1;
        private ListBox lstNhap;
    }
}