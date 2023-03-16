
namespace anhquan
{
    partial class frmbai4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(88, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 184);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số cần tìm:";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(602, 138);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(100, 26);
            this.txtnhap.TabIndex = 2;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(602, 181);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(88, 32);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "Tìm số";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(554, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết quả:";
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Location = new System.Drawing.Point(628, 287);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(13, 20);
            this.lbketqua.TabIndex = 5;
            this.lbketqua.Text = ".";
            // 
            // frmbai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "frmbai4";
            this.Text = "Chương trình chính";
            this.Load += new System.EventHandler(this.frmbai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbketqua;
    }
}