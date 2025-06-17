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
using PTTKHTTTProject.DAO;
using PTTKHTTTProject.GDI;

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

        public bool CheckUser(string username, string password)
        {
            object obj = DataProvider.Instance.ExecuteScalar(
                "EXEC usp_CheckTaiKhoan ?, ?",
                username.Trim(), password.Trim());

            Debug.WriteLine($"Calling usp_CheckTaiKhoan with '{username.Trim()}', '{password.Trim()}'");

            if (obj == null || obj == DBNull.Value) return false;
            return (bool)obj;
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

            if (CheckUser(username, password))
            {
                fHome fh = new fHome();
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
