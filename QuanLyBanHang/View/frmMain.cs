﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                e.Cancel = true;
        }

        private void lbExit_MouseMove(object sender, MouseEventArgs e)
        {
            lbExit.BackColor = Color.Red;
        }
        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.BackColor = Color.Transparent;
        }






        
    }
}
