using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.View
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                e.Cancel = true;
        }

        private void thêmNhânViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSignUp fSU = new frmSignUp();
            fSU.ShowDialog();
        }
    }
}
