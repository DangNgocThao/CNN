namespace Tuan4
{
    partial class Form1
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.chkcong = new System.Windows.Forms.RadioButton();
            this.chktru = new System.Windows.Forms.RadioButton();
            this.chknhan = new System.Windows.Forms.RadioButton();
            this.chkchia = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(49, 20);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(75, 20);
            this.txta.TabIndex = 3;
            this.txta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txta_KeyDown);
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            this.txta.Leave += new System.EventHandler(this.txta_Leave);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(170, 20);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(75, 20);
            this.txtb.TabIndex = 4;
            this.txtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txta_KeyDown);
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            this.txtb.Leave += new System.EventHandler(this.txta_Leave);
            // 
            // txtkq
            // 
            this.txtkq.Enabled = false;
            this.txtkq.Location = new System.Drawing.Point(71, 57);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(174, 20);
            this.txtkq.TabIndex = 5;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(93, 128);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 33);
            this.btntinh.TabIndex = 6;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // chkcong
            // 
            this.chkcong.AutoSize = true;
            this.chkcong.Checked = true;
            this.chkcong.Location = new System.Drawing.Point(24, 94);
            this.chkcong.Name = "chkcong";
            this.chkcong.Size = new System.Drawing.Size(31, 17);
            this.chkcong.TabIndex = 7;
            this.chkcong.TabStop = true;
            this.chkcong.Text = "+";
            this.chkcong.UseVisualStyleBackColor = true;
            // 
            // chktru
            // 
            this.chktru.AutoSize = true;
            this.chktru.Location = new System.Drawing.Point(87, 94);
            this.chktru.Name = "chktru";
            this.chktru.Size = new System.Drawing.Size(28, 17);
            this.chktru.TabIndex = 8;
            this.chktru.Text = "-";
            this.chktru.UseVisualStyleBackColor = true;
            // 
            // chknhan
            // 
            this.chknhan.AutoSize = true;
            this.chknhan.Location = new System.Drawing.Point(150, 94);
            this.chknhan.Name = "chknhan";
            this.chknhan.Size = new System.Drawing.Size(30, 17);
            this.chknhan.TabIndex = 9;
            this.chknhan.Text = "x";
            this.chknhan.UseVisualStyleBackColor = true;
            // 
            // chkchia
            // 
            this.chkchia.AutoSize = true;
            this.chkchia.Location = new System.Drawing.Point(215, 94);
            this.chkchia.Name = "chkchia";
            this.chkchia.Size = new System.Drawing.Size(30, 17);
            this.chkchia.TabIndex = 10;
            this.chkchia.Text = "/";
            this.chkchia.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 173);
            this.Controls.Add(this.chkchia);
            this.Controls.Add(this.chknhan);
            this.Controls.Add(this.chktru);
            this.Controls.Add(this.chkcong);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.RadioButton chkcong;
        private System.Windows.Forms.RadioButton chktru;
        private System.Windows.Forms.RadioButton chknhan;
        private System.Windows.Forms.RadioButton chkchia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

