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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int count = 0;

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = lbName.Text;
            lbName.Text = s.Substring(1) + s.Substring(0, 1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            count++;
            if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            {
                this.Visible = false;
                frmAdmin fA = new frmAdmin();
                DialogResult res = fA.ShowDialog();
                this.Visible = true;
                count = 0;
            }
            else if (txtUserName.Text == "PhuongVy" && txtPassword.Text == "GiaMan")
            {
                this.Visible = false;
                frmMain fM = new frmMain();
                DialogResult res = fM.ShowDialog();
                this.Visible = true;
                count = 0;
            }
            else if (count < 3)
            {
                MessageBox.Show("Nhập sai UserName hoặc Password! Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vượt quá số lần cho phép nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Visible = false;
                FrmError fE = new FrmError();
                fE.ShowDialog();
            }
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtUserName.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogIn.PerformClick();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                e.Cancel = true;
        }



        
    }
}
