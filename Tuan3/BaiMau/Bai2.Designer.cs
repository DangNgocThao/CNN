namespace BaiMau
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtDCE = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.btnDK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "(*)";
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(149, 37);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(209, 20);
            this.txtTDN.TabIndex = 7;
            this.txtTDN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTDN_KeyDown);
            this.txtTDN.Leave += new System.EventHandler(this.txtTDN_Leave);
            // 
            // txtDCE
            // 
            this.txtDCE.Location = new System.Drawing.Point(149, 83);
            this.txtDCE.Name = "txtDCE";
            this.txtDCE.Size = new System.Drawing.Size(209, 20);
            this.txtDCE.TabIndex = 8;
            this.txtDCE.TextChanged += new System.EventHandler(this.txtDCE_TextChanged);
            this.txtDCE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTDN_KeyDown);
            this.txtDCE.Leave += new System.EventHandler(this.txtTDN_Leave);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(149, 129);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(209, 20);
            this.txtMK.TabIndex = 9;
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTDN_KeyDown);
            this.txtMK.Leave += new System.EventHandler(this.txtTDN_Leave);
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(149, 173);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.Size = new System.Drawing.Size(209, 20);
            this.txtXNMK.TabIndex = 10;
            this.txtXNMK.UseSystemPasswordChar = true;
            this.txtXNMK.TextChanged += new System.EventHandler(this.txtXNMK_TextChanged);
            this.txtXNMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTDN_KeyDown);
            // 
            // btnDK
            // 
            this.btnDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDK.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDK.Location = new System.Drawing.Point(149, 205);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(209, 48);
            this.btnDK.TabIndex = 11;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(174, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đăng ký tài khoản";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 265);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.txtXNMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtDCE);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtDCE;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}