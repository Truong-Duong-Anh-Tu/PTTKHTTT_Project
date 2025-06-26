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

            //Debug.WriteLine(BCrypt.Net.BCrypt.HashPassword(password.Trim()));

            if (TaiKhoanBUS.checkSignIn(username, password))
            {
                string role = TaiKhoanBUS.CheckRole(username);

                if (role == "Nhập liệu")
                {
                    fNhapLieu fnl= new fNhapLieu(username);
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
                    fQuanTriDL fqt = new fQuanTriDL();
                    this.Hide();
                    fqt.ShowDialog();
                    this.Show();
                }   
                else if (role == "Coi thi")
                {
                    fCoiThi fct = new fCoiThi();
                    this.Hide();
                    fct.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tai khaon chua co vai tro de dang nhap", "Miss Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ten dang nhap hoac mat khau sai.", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
