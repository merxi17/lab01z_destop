﻿using System;
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
    public partial class frmbai4 : Form
    {
        public frmbai4()
        {
            InitializeComponent();
        }

        private void frmbai4_Load(object sender, EventArgs e)
        {
            int so;
            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
               so= rand.Next(1, 100);
                listBox1.Items.Add(so);

            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            int socantim = int.Parse(txtnhap.Text);
            foreach (int so in listBox1.Items)
            {
                if (so == socantim)
                {
                    lbketqua.Text = "Đẫ tìm thấy";
                    break;
                }
                else
                    lbketqua.Text = "Không tìm thấy";
                break;

            }
            
        }
    }
}
