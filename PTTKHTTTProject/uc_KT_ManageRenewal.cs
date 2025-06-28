using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject
{
    public partial class uc_KT_ManageRenewal : UserControl
    {
        public uc_KT_ManageRenewal()
        {
            InitializeComponent();
        }

        private void uc_KT_ManageRenewal_Load(object sender, EventArgs e)
        {
            dtgvResult.DataSource = ManageRenewalBUS.loadRenewal();
            var btnCol = new DataGridViewButtonColumn
            {
                Name = "btnAction",
                HeaderText = "Hành động",
                Text = "Tạo phiếu",
                UseColumnTextForButtonValue = true
            };
            dtgvResult.Columns.Add(btnCol);
        }

        //private void pnlManageResult_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
