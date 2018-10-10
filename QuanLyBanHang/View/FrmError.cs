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
    public partial class FrmError : Form
    {
        public FrmError()
        {
            InitializeComponent();
        }

        private void FrmError_Load(object sender, EventArgs e)
        {
            Size s = new Size();
            s = SystemInformation.WorkingArea.Size;
            Height = s.Height;
            Width = s.Width;
            pictureBox1.Dock = DockStyle.Fill;
            
            
        }



        
    }
}
