namespace Tuan8
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bM1ToolStripMenuItem,
            this.bM2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bM1ToolStripMenuItem
            // 
            this.bM1ToolStripMenuItem.Name = "bM1ToolStripMenuItem";
            this.bM1ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.bM1ToolStripMenuItem.Text = "BM1";
            this.bM1ToolStripMenuItem.Click += new System.EventHandler(this.bM1ToolStripMenuItem_Click);
            // 
            // bM2ToolStripMenuItem
            // 
            this.bM2ToolStripMenuItem.Name = "bM2ToolStripMenuItem";
            this.bM2ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.bM2ToolStripMenuItem.Text = "BM2";
            this.bM2ToolStripMenuItem.Click += new System.EventHandler(this.bM2ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 355);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bM1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bM2ToolStripMenuItem;
    }
}