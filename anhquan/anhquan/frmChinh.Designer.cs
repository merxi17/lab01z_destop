namespace anhquan
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phạmAnhQuânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmbai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmbai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phạmAnhQuânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phạmAnhQuânToolStripMenuItem
            // 
            this.phạmAnhQuânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmbai1,
            this.frmbai2,
            this.bài3ToolStripMenuItem,
            this.bài4ToolStripMenuItem});
            this.phạmAnhQuânToolStripMenuItem.Name = "phạmAnhQuânToolStripMenuItem";
            this.phạmAnhQuânToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.phạmAnhQuânToolStripMenuItem.Text = "Phạm Anh Quân";
            // 
            // frmbai1
            // 
            this.frmbai1.Image = ((System.Drawing.Image)(resources.GetObject("frmbai1.Image")));
            this.frmbai1.Name = "frmbai1";
            this.frmbai1.Size = new System.Drawing.Size(270, 34);
            this.frmbai1.Text = "Bài 1";
            this.frmbai1.Click += new System.EventHandler(this.frmbai1_Click);
            // 
            // frmbai2
            // 
            this.frmbai2.Image = ((System.Drawing.Image)(resources.GetObject("frmbai2.Image")));
            this.frmbai2.Name = "frmbai2";
            this.frmbai2.Size = new System.Drawing.Size(270, 34);
            this.frmbai2.Text = "Bài 2";
            this.frmbai2.Click += new System.EventHandler(this.frmbai2_Click);
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài3ToolStripMenuItem.Image")));
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            this.bài3ToolStripMenuItem.Click += new System.EventHandler(this.bài3ToolStripMenuItem_Click);
            // 
            // bài4ToolStripMenuItem
            // 
            this.bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            this.bài4ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bài4ToolStripMenuItem.Text = "Bài 4";
            this.bài4ToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChinh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phạmAnhQuânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmbai1;
        private System.Windows.Forms.ToolStripMenuItem frmbai2;
        private System.Windows.Forms.ToolStripMenuItem bài3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài4ToolStripMenuItem;
    }
}

