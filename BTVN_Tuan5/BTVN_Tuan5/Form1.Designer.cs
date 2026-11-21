namespace BTVN_Tuan5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.cboTA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.cboTV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTV);
            this.tabPage1.Controls.Add(this.cboTA);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ANH - VIỆT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTV
            // 
            this.txtTV.Location = new System.Drawing.Point(222, 36);
            this.txtTV.Multiline = true;
            this.txtTV.Name = "txtTV";
            this.txtTV.Size = new System.Drawing.Size(185, 251);
            this.txtTV.TabIndex = 7;
            // 
            // cboTA
            // 
            this.cboTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboTA.FormattingEnabled = true;
            this.cboTA.Location = new System.Drawing.Point(15, 36);
            this.cboTA.Name = "cboTA";
            this.cboTA.Size = new System.Drawing.Size(185, 263);
            this.cboTA.TabIndex = 6;
            this.cboTA.TextChanged += new System.EventHandler(this.cboTA_TextChanged);
            this.cboTA.Click += new System.EventHandler(this.cboTA_Click);
            this.cboTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTA_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiếng Việt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiếng Anh";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTA);
            this.tabPage2.Controls.Add(this.cboTV);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VIỆT - ANH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(222, 36);
            this.txtTA.Multiline = true;
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(185, 252);
            this.txtTA.TabIndex = 3;
            // 
            // cboTV
            // 
            this.cboTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboTV.FormattingEnabled = true;
            this.cboTV.Location = new System.Drawing.Point(15, 36);
            this.cboTV.Name = "cboTV";
            this.cboTV.Size = new System.Drawing.Size(185, 263);
            this.cboTV.TabIndex = 2;
            this.cboTV.TextChanged += new System.EventHandler(this.cboTV_TextChanged);
            this.cboTV.Click += new System.EventHandler(this.cboTV_Click);
            this.cboTV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTV_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiếng Anh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiếng Việt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtTA;
        private Label label2;
        private Label label1;
        private TextBox txtTV;
        private Label label3;
        private Label label4;
        private ComboBox cboTA;
        private ComboBox cboTV;
    }
}