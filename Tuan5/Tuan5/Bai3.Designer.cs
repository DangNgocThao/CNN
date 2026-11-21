namespace Tuan5
{
    partial class Bai3
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
            this.trv_DS = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_phongban = new System.Windows.Forms.TextBox();
            this.btn_ThemPB = new System.Windows.Forms.Button();
            this.btn_XoaPB = new System.Windows.Forms.Button();
            this.cbo_phongban = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng ban";
            // 
            // trv_DS
            // 
            this.trv_DS.Location = new System.Drawing.Point(16, 40);
            this.trv_DS.Name = "trv_DS";
            this.trv_DS.Size = new System.Drawing.Size(233, 257);
            this.trv_DS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(279, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "HỒ SƠ NHÂN VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã số";
            // 
            // txt_maso
            // 
            this.txt_maso.Location = new System.Drawing.Point(348, 55);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new System.Drawing.Size(98, 20);
            this.txt_maso.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(532, 55);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(200, 20);
            this.txt_hoten.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phòng ban";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(348, 101);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(384, 20);
            this.txt_diachi.TabIndex = 9;
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(348, 202);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemNV.TabIndex = 11;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(474, 201);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 12;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phòng ban";
            // 
            // txt_phongban
            // 
            this.txt_phongban.Location = new System.Drawing.Point(78, 307);
            this.txt_phongban.Name = "txt_phongban";
            this.txt_phongban.Size = new System.Drawing.Size(171, 20);
            this.txt_phongban.TabIndex = 14;
            // 
            // btn_ThemPB
            // 
            this.btn_ThemPB.Location = new System.Drawing.Point(138, 337);
            this.btn_ThemPB.Name = "btn_ThemPB";
            this.btn_ThemPB.Size = new System.Drawing.Size(111, 23);
            this.btn_ThemPB.TabIndex = 15;
            this.btn_ThemPB.Text = "Thêm phòng ban";
            this.btn_ThemPB.UseVisualStyleBackColor = true;
            this.btn_ThemPB.Click += new System.EventHandler(this.btn_ThemPB_Click);
            // 
            // btn_XoaPB
            // 
            this.btn_XoaPB.Location = new System.Drawing.Point(138, 369);
            this.btn_XoaPB.Name = "btn_XoaPB";
            this.btn_XoaPB.Size = new System.Drawing.Size(111, 23);
            this.btn_XoaPB.TabIndex = 16;
            this.btn_XoaPB.Text = "Xóa phòng ban";
            this.btn_XoaPB.UseVisualStyleBackColor = true;
            this.btn_XoaPB.Click += new System.EventHandler(this.btn_XoaPB_Click);
            // 
            // cbo_phongban
            // 
            this.cbo_phongban.FormattingEnabled = true;
            this.cbo_phongban.Location = new System.Drawing.Point(348, 151);
            this.cbo_phongban.Name = "cbo_phongban";
            this.cbo_phongban.Size = new System.Drawing.Size(384, 21);
            this.cbo_phongban.TabIndex = 17;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 415);
            this.Controls.Add(this.cbo_phongban);
            this.Controls.Add(this.btn_XoaPB);
            this.Controls.Add(this.btn_ThemPB);
            this.Controls.Add(this.txt_phongban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trv_DS);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Thêm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai3_FormClosing);
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trv_DS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_phongban;
        private System.Windows.Forms.Button btn_ThemPB;
        private System.Windows.Forms.Button btn_XoaPB;
        private System.Windows.Forms.ComboBox cbo_phongban;
    }
}