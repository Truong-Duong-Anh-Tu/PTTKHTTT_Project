using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            fHome fh = new fHome();
            this.Hide();
            fh.ShowDialog();
            this.Show();
        }
    }
}
