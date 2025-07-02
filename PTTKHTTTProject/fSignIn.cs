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
            string email = tbxUsername.Text;
            string password = tbxPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TaiKhoanBUS.checkSignIn(email, password))
            {
                string username = TaiKhoanBUS.getUsername(email);
                string role = TaiKhoanBUS.CheckRole(username);

                if (role == "Nhập liệu")
                {
                    fNhapLieu fnl = new fNhapLieu(username);
                    this.Hide();
                    fnl.ShowDialog();
                    this.Show();
                }
                else if (role == "Tiếp nhận")
                {
                    fTiepNhan ftn = new fTiepNhan();
                    this.Hide();
                    ftn.ShowDialog();
                    this.Show();
                }
                else if (role == "Kế toán")
                {
                    fKeToan fkt = new fKeToan(username);
                    this.Hide();
                    fkt.ShowDialog();
                    this.Show();
                }
                else if (role == "Quản trị hệ thống")
                {
                    fQuanTriDL fqt = new fQuanTriDL(username);
                    this.Hide();
                    fqt.ShowDialog();
                    this.Show();
                }
                else if (role == "Coi thi")
                {
                    fCoiThi fct = new fCoiThi(username);
                    this.Hide();
                    fct.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản chưa có vai trò để đăng nhập", "Miss Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai.", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {

        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
