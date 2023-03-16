namespace anhquan
{
    partial class frmBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxtumoi = new System.Windows.Forms.TextBox();
            this.txtboxnghia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnthem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthienthi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nghĩa của từ:";
            // 
            // txtboxtumoi
            // 
            this.txtboxtumoi.Location = new System.Drawing.Point(154, 48);
            this.txtboxtumoi.Name = "txtboxtumoi";
            this.txtboxtumoi.Size = new System.Drawing.Size(136, 26);
            this.txtboxtumoi.TabIndex = 2;
            // 
            // txtboxnghia
            // 
            this.txtboxnghia.Location = new System.Drawing.Point(154, 89);
            this.txtboxnghia.Name = "txtboxnghia";
            this.txtboxnghia.Size = new System.Drawing.Size(183, 26);
            this.txtboxnghia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DANH SÁCH TỪ MỚI";
            // 
            // bttnthem
            // 
            this.bttnthem.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bttnthem.Location = new System.Drawing.Point(169, 121);
            this.bttnthem.Name = "bttnthem";
            this.bttnthem.Size = new System.Drawing.Size(110, 32);
            this.bttnthem.TabIndex = 6;
            this.bttnthem.Text = "Thêm từ mới";
            this.bttnthem.UseVisualStyleBackColor = true;
            this.bttnthem.Click += new System.EventHandler(this.bttnthem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(43, 229);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(294, 164);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "NGHĨA CỦA TỪ";
            // 
            // txthienthi
            // 
            this.txthienthi.Location = new System.Drawing.Point(462, 241);
            this.txthienthi.Multiline = true;
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.ReadOnly = true;
            this.txthienthi.Size = new System.Drawing.Size(302, 144);
            this.txthienthi.TabIndex = 9;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bttnthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxnghia);
            this.Controls.Add(this.txtboxtumoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "từ điển Anh-Việt";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxtumoi;
        private System.Windows.Forms.TextBox txtboxnghia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnthem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthienthi;
    }
}