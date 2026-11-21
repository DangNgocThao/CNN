namespace BTVN_Tuan4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBa = new System.Windows.Forms.RadioButton();
            this.rdoPDoi = new System.Windows.Forms.RadioButton();
            this.rdoPDon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMNcNong = new System.Windows.Forms.CheckBox();
            this.chkNet = new System.Windows.Forms.CheckBox();
            this.chkTivi = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAnSang = new System.Windows.Forms.CheckBox();
            this.chkKaraoke = new System.Windows.Forms.CheckBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnTongKet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuot = new System.Windows.Forms.TextBox();
            this.txtTongSoTien = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH SẠN THANH THANH – TRẢ PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số ngày ở:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(97, 53);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 23);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(97, 93);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(290, 23);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Location = new System.Drawing.Point(97, 132);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(100, 23);
            this.txtSoNgayO.TabIndex = 6;
            this.txtSoNgayO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoNgayO.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            this.txtSoNgayO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgayO_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBa);
            this.groupBox1.Controls.Add(this.rdoPDoi);
            this.groupBox1.Controls.Add(this.rdoPDon);
            this.groupBox1.Location = new System.Drawing.Point(30, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại phòng";
            // 
            // rdoBa
            // 
            this.rdoBa.AutoSize = true;
            this.rdoBa.Location = new System.Drawing.Point(19, 72);
            this.rdoBa.Name = "rdoBa";
            this.rdoBa.Size = new System.Drawing.Size(76, 19);
            this.rdoBa.TabIndex = 2;
            this.rdoBa.Text = "Phòng ba";
            this.rdoBa.UseVisualStyleBackColor = true;
            // 
            // rdoPDoi
            // 
            this.rdoPDoi.AutoSize = true;
            this.rdoPDoi.Location = new System.Drawing.Point(19, 47);
            this.rdoPDoi.Name = "rdoPDoi";
            this.rdoPDoi.Size = new System.Drawing.Size(80, 19);
            this.rdoPDoi.TabIndex = 1;
            this.rdoPDoi.Text = "Phòng đôi";
            this.rdoPDoi.UseVisualStyleBackColor = true;
            // 
            // rdoPDon
            // 
            this.rdoPDon.AutoSize = true;
            this.rdoPDon.Checked = true;
            this.rdoPDon.Location = new System.Drawing.Point(19, 22);
            this.rdoPDon.Name = "rdoPDon";
            this.rdoPDon.Size = new System.Drawing.Size(84, 19);
            this.rdoPDon.TabIndex = 0;
            this.rdoPDon.TabStop = true;
            this.rdoPDon.Text = "Phòng đơn";
            this.rdoPDon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMNcNong);
            this.groupBox2.Controls.Add(this.chkNet);
            this.groupBox2.Controls.Add(this.chkTivi);
            this.groupBox2.Location = new System.Drawing.Point(152, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiện nghi";
            // 
            // chkMNcNong
            // 
            this.chkMNcNong.AutoSize = true;
            this.chkMNcNong.Location = new System.Drawing.Point(13, 73);
            this.chkMNcNong.Name = "chkMNcNong";
            this.chkMNcNong.Size = new System.Drawing.Size(110, 19);
            this.chkMNcNong.TabIndex = 2;
            this.chkMNcNong.Text = "Máy nước nóng";
            this.chkMNcNong.UseVisualStyleBackColor = true;
            // 
            // chkNet
            // 
            this.chkNet.AutoSize = true;
            this.chkNet.Location = new System.Drawing.Point(13, 47);
            this.chkNet.Name = "chkNet";
            this.chkNet.Size = new System.Drawing.Size(67, 19);
            this.chkNet.TabIndex = 1;
            this.chkNet.Text = "Internet";
            this.chkNet.UseVisualStyleBackColor = true;
            // 
            // chkTivi
            // 
            this.chkTivi.AutoSize = true;
            this.chkTivi.Location = new System.Drawing.Point(13, 23);
            this.chkTivi.Name = "chkTivi";
            this.chkTivi.Size = new System.Drawing.Size(44, 19);
            this.chkTivi.TabIndex = 0;
            this.chkTivi.Text = "Tivi";
            this.chkTivi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAnSang);
            this.groupBox3.Controls.Add(this.chkKaraoke);
            this.groupBox3.Location = new System.Drawing.Point(285, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(102, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dịch vụ";
            // 
            // chkAnSang
            // 
            this.chkAnSang.AutoSize = true;
            this.chkAnSang.Location = new System.Drawing.Point(16, 61);
            this.chkAnSang.Name = "chkAnSang";
            this.chkAnSang.Size = new System.Drawing.Size(69, 19);
            this.chkAnSang.TabIndex = 1;
            this.chkAnSang.Text = "Ăn sáng";
            this.chkAnSang.UseVisualStyleBackColor = true;
            // 
            // chkKaraoke
            // 
            this.chkKaraoke.AutoSize = true;
            this.chkKaraoke.Location = new System.Drawing.Point(16, 30);
            this.chkKaraoke.Name = "chkKaraoke";
            this.chkKaraoke.Size = new System.Drawing.Size(68, 19);
            this.chkKaraoke.TabIndex = 0;
            this.chkKaraoke.Text = "Karaoke";
            this.chkKaraoke.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(400, 52);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Enabled = false;
            this.btnNhapMoi.Location = new System.Drawing.Point(481, 52);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(75, 23);
            this.btnNhapMoi.TabIndex = 11;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(469, 88);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 23);
            this.txtThanhTien.TabIndex = 13;
            // 
            // btnTongKet
            // 
            this.btnTongKet.Enabled = false;
            this.btnTongKet.Location = new System.Drawing.Point(400, 127);
            this.btnTongKet.Name = "btnTongKet";
            this.btnTongKet.Size = new System.Drawing.Size(75, 23);
            this.btnTongKet.TabIndex = 14;
            this.btnTongKet.Text = "Tổng kết";
            this.btnTongKet.UseVisualStyleBackColor = true;
            this.btnTongKet.Click += new System.EventHandler(this.btnTongKet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số lượt người:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tổng số tiền:";
            // 
            // txtSoLuot
            // 
            this.txtSoLuot.Enabled = false;
            this.txtSoLuot.Location = new System.Drawing.Point(87, 28);
            this.txtSoLuot.Name = "txtSoLuot";
            this.txtSoLuot.Size = new System.Drawing.Size(100, 23);
            this.txtSoLuot.TabIndex = 18;
            // 
            // txtTongSoTien
            // 
            this.txtTongSoTien.Enabled = false;
            this.txtTongSoTien.Location = new System.Drawing.Point(87, 61);
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.Size = new System.Drawing.Size(100, 23);
            this.txtTongSoTien.TabIndex = 19;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(400, 264);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTongSoTien);
            this.groupBox4.Controls.Add(this.txtSoLuot);
            this.groupBox4.Location = new System.Drawing.Point(400, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tổng kết";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 294);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTongKet);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoNgayO);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorProvider errorProvider1;
        private GroupBox groupBox4;
        private Label label6;
        private Label label7;
        private TextBox txtTongSoTien;
        private TextBox txtSoLuot;
        private Button btnThoat;
        private Button btnTongKet;
        private TextBox txtThanhTien;
        private Label label5;
        private Button btnNhapMoi;
        private Button btnThanhToan;
        private GroupBox groupBox3;
        private CheckBox chkAnSang;
        private CheckBox chkKaraoke;
        private GroupBox groupBox2;
        private CheckBox chkMNcNong;
        private CheckBox chkNet;
        private CheckBox chkTivi;
        private GroupBox groupBox1;
        private RadioButton rdoBa;
        private RadioButton rdoPDoi;
        private RadioButton rdoPDon;
        private TextBox txtSoNgayO;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}