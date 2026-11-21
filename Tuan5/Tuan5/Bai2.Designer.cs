namespace Tuan5
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
            this.btn_loadDL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_dt = new System.Windows.Forms.ComboBox();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_loadDL
            // 
            this.btn_loadDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadDL.Location = new System.Drawing.Point(16, 12);
            this.btn_loadDL.Name = "btn_loadDL";
            this.btn_loadDL.Size = new System.Drawing.Size(166, 23);
            this.btn_loadDL.TabIndex = 0;
            this.btn_loadDL.Text = "Load dữ liệu Combobox";
            this.btn_loadDL.UseVisualStyleBackColor = true;
            this.btn_loadDL.Click += new System.EventHandler(this.btn_loadDL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dân tộc";
            // 
            // cbo_dt
            // 
            this.cbo_dt.FormattingEnabled = true;
            this.cbo_dt.Location = new System.Drawing.Point(122, 51);
            this.cbo_dt.Name = "cbo_dt";
            this.cbo_dt.Size = new System.Drawing.Size(121, 21);
            this.cbo_dt.TabIndex = 2;
            this.cbo_dt.SelectedIndexChanged += new System.EventHandler(this.cbo_dt_SelectedIndexChanged);
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthi.Location = new System.Drawing.Point(93, 107);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(75, 23);
            this.btn_hienthi.TabIndex = 3;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.ForeColor = System.Drawing.Color.Red;
            this.lbl_kq.Location = new System.Drawing.Point(90, 150);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(44, 13);
            this.lbl_kq.TabIndex = 4;
            this.lbl_kq.Text = "Kết quả";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.cbo_dt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loadDL);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadDL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_dt;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Label lbl_kq;
    }
}