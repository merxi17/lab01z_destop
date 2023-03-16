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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmbai1_Click(object sender, EventArgs e)
        {
            frmBai1 frmBai1 = new frmBai1();
            frmBai1.MdiParent = this;
            frmBai1.Show();

        }

        private void frmbai2_Click(object sender, EventArgs e)
        {
            frmBai2 frmBai2 = new frmBai2();
            frmBai2.MdiParent = this;
            frmBai2.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai3 frmBai3 = new frmBai3();
            frmBai3.MdiParent = this;
            frmBai3.Show();

        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbai4 frmbai4 = new frmbai4();
            frmbai4.MdiParent = this;
            frmbai4.Show();

        }
    }
}
