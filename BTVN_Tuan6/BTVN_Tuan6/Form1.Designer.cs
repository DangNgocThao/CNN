namespace BTVN_Tuan6
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
            this.txtGiay = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPhut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGiay
            // 
            this.txtGiay.AutoSize = true;
            this.txtGiay.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGiay.Location = new System.Drawing.Point(131, 9);
            this.txtGiay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGiay.Name = "txtGiay";
            this.txtGiay.Size = new System.Drawing.Size(45, 35);
            this.txtGiay.TabIndex = 6;
            this.txtGiay.Text = "00";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(78, 73);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(88, 27);
            this.btnBatDau.TabIndex = 5;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPhut
            // 
            this.txtPhut.AutoSize = true;
            this.txtPhut.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPhut.Location = new System.Drawing.Point(72, 9);
            this.txtPhut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(45, 35);
            this.txtPhut.TabIndex = 7;
            this.txtPhut.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhut);
            this.Controls.Add(this.txtGiay);
            this.Controls.Add(this.btnBatDau);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtGiay;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtPhut;
        private System.Windows.Forms.Label label1;
    }
}

