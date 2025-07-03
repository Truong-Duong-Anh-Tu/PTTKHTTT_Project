using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQLyLichThi : UserControl
    {
        public adminQLyLichThi()
        {
            InitializeComponent();
        }

        private void adminQLyLichThi_Load(object sender, EventArgs e)
        {

        }

        private void labelQuanLylichThi_Click(object sender, EventArgs e)
        {

        }

        private void buttonThemLichThi_Click(object sender, EventArgs e)
        {
            fAdminThemLichThi themLichThiForm = new fAdminThemLichThi();
            themLichThiForm.ShowDialog();
        }
    }
}
