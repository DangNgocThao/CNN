namespace Tuan6
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăng1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăng2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăng3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăng1ToolStripMenuItem,
            this.chứcNăng2ToolStripMenuItem,
            this.chứcNăng3ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chứcNăng1ToolStripMenuItem
            // 
            this.chứcNăng1ToolStripMenuItem.Name = "chứcNăng1ToolStripMenuItem";
            this.chứcNăng1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chứcNăng1ToolStripMenuItem.Text = "Chức năng 1";
            this.chứcNăng1ToolStripMenuItem.Click += new System.EventHandler(this.chứcNăng1ToolStripMenuItem_Click);
            // 
            // chứcNăng2ToolStripMenuItem
            // 
            this.chứcNăng2ToolStripMenuItem.Name = "chứcNăng2ToolStripMenuItem";
            this.chứcNăng2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chứcNăng2ToolStripMenuItem.Text = "Chức năng 2";
            this.chứcNăng2ToolStripMenuItem.Click += new System.EventHandler(this.chứcNăng2ToolStripMenuItem_Click);
            // 
            // chứcNăng3ToolStripMenuItem
            // 
            this.chứcNăng3ToolStripMenuItem.Name = "chứcNăng3ToolStripMenuItem";
            this.chứcNăng3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chứcNăng3ToolStripMenuItem.Text = "Chức năng 3";
            this.chứcNăng3ToolStripMenuItem.Click += new System.EventHandler(this.chứcNăng3ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăng1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăng2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăng3ToolStripMenuItem;
    }
}