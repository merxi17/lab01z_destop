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
    public partial class frmBai3 : Form
    {
        List<string> list= new List<string>();

        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void bttnthem_Click(object sender, EventArgs e)
        {
            var tu = txtboxtumoi.Text;
            var nghia = txtboxnghia.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;

            txthienthi.Text = list[stt];
        }
    }
}
