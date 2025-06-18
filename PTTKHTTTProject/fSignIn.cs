using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject
{
    public partial class fSignIn : Form
    {
        public fSignIn()
        {
            InitializeComponent();
        }

        private void fSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TaiKhoanBUS.DangNhap(username, password))
            {
                fNhapLieu fh = new fNhapLieu();
                this.Hide();
                fh.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Ten dang nhap hoac mat khau sai.", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
