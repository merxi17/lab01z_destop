namespace anhquan
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnchon = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsotien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnchon);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnchon
            // 
            this.btnchon.Location = new System.Drawing.Point(247, 196);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(118, 41);
            this.btnchon.TabIndex = 1;
            this.btnchon.Text = "Chọn hàng >";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột ",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.listBox1.Location = new System.Drawing.Point(51, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 184);
            this.listBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách hàng hóa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbsotien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnTT);
            this.panel2.Controls.Add(this.btnBo);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(416, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 426);
            this.panel2.TabIndex = 1;
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(162, 331);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(113, 32);
            this.btnTT.TabIndex = 3;
            this.btnTT.Text = "Tính Tiền";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnBo
            // 
            this.btnBo.Location = new System.Drawing.Point(33, 196);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(123, 41);
            this.btnBo.TabIndex = 2;
            this.btnBo.Text = "< Bỏ hàng";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(162, 126);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(181, 184);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các mặt hàng khách đã mua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng thành tiền thanh toán:";
            // 
            // lbsotien
            // 
            this.lbsotien.AutoSize = true;
            this.lbsotien.ForeColor = System.Drawing.Color.Blue;
            this.lbsotien.Location = new System.Drawing.Point(274, 385);
            this.lbsotien.Name = "lbsotien";
            this.lbsotien.Size = new System.Drawing.Size(13, 20);
            this.lbsotien.TabIndex = 5;
            this.lbsotien.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbsotien;
        public System.Windows.Forms.Label label3;
    }
}