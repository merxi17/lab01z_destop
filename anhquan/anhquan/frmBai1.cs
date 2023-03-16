using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anhquan
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_TextChanged(object sender, EventArgs e)
        {
            txtDongia.Text = "22000";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtDongia.Text = "21000";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtDongia.Text = "20000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse(txtDongia.Text) * int.Parse(txtSoluong.Text);
            label6.Text = soTien.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

     
    }
}
