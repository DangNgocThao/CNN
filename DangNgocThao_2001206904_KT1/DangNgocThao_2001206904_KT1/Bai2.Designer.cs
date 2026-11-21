namespace DangNgocThao_2001206904_KT1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtDaySo = new System.Windows.Forms.TextBox();
            this.txtSHT = new System.Windows.Forms.TextBox();
            this.txtMaxChan = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên dương n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dãy số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Các phần tử là số hoàn thiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số chẵn lớn nhất trong dãy:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(156, 6);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 20);
            this.txtNhap.TabIndex = 4;
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            this.txtNhap.Leave += new System.EventHandler(this.txtNhap_Leave);
            // 
            // txtDaySo
            // 
            this.txtDaySo.Location = new System.Drawing.Point(58, 48);
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.Size = new System.Drawing.Size(423, 20);
            this.txtDaySo.TabIndex = 5;
            // 
            // txtSHT
            // 
            this.txtSHT.Location = new System.Drawing.Point(157, 93);
            this.txtSHT.Name = "txtSHT";
            this.txtSHT.Size = new System.Drawing.Size(324, 20);
            this.txtSHT.TabIndex = 6;
            // 
            // txtMaxChan
            // 
            this.txtMaxChan.Location = new System.Drawing.Point(156, 142);
            this.txtMaxChan.Name = "txtMaxChan";
            this.txtMaxChan.Size = new System.Drawing.Size(325, 20);
            this.txtMaxChan.TabIndex = 7;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(271, 4);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(210, 23);
            this.btnTao.TabIndex = 8;
            this.btnTao.Text = "Tạo n số nguyên dương ngẫu nhiên";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(306, 187);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(75, 23);
            this.btnXuLy.TabIndex = 9;
            this.btnXuLy.Text = "Xử lý";
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 222);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtMaxChan);
            this.Controls.Add(this.txtSHT);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtDaySo;
        private System.Windows.Forms.TextBox txtSHT;
        private System.Windows.Forms.TextBox txtMaxChan;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}