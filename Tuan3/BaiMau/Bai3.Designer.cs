namespace BaiMau
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtUCLN = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTH = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtBCNN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ước số chung lớn nhất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bội số chung nhỏ nhất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ước Số Chung - Bội Số Chung";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(113, 62);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(133, 20);
            this.txta.TabIndex = 5;
            this.txta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txta_KeyDown);
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            this.txta.Leave += new System.EventHandler(this.txta_Leave);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(113, 91);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(133, 20);
            this.txtb.TabIndex = 6;
            this.txtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txta_KeyDown);
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            this.txtb.Leave += new System.EventHandler(this.txta_Leave);
            // 
            // txtUCLN
            // 
            this.txtUCLN.Location = new System.Drawing.Point(172, 119);
            this.txtUCLN.Name = "txtUCLN";
            this.txtUCLN.Size = new System.Drawing.Size(74, 20);
            this.txtUCLN.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTH
            // 
            this.btnTH.Location = new System.Drawing.Point(12, 183);
            this.btnTH.Name = "btnTH";
            this.btnTH.Size = new System.Drawing.Size(75, 23);
            this.btnTH.TabIndex = 8;
            this.btnTH.Text = "Thực Hiện";
            this.btnTH.UseVisualStyleBackColor = true;
            this.btnTH.Click += new System.EventHandler(this.btnTH_Click);
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(102, 183);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(75, 23);
            this.btnTT.TabIndex = 9;
            this.btnTT.Text = "Tiếp Tục";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(197, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtBCNN
            // 
            this.txtBCNN.Location = new System.Drawing.Point(172, 152);
            this.txtBCNN.Name = "txtBCNN";
            this.txtBCNN.Size = new System.Drawing.Size(74, 20);
            this.txtBCNN.TabIndex = 11;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 224);
            this.Controls.Add(this.txtBCNN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnTH);
            this.Controls.Add(this.txtUCLN);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai3_FormClosing);
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
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtUCLN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtBCNN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnTH;
    }
}