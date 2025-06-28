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
    public partial class uc_KT_ManageReceipt : UserControl
    {
        public uc_KT_ManageReceipt()
        {
            InitializeComponent();
        }

        private void loadReceiptToDTGV()
        {
            dtgvResult.DataSource = ManageReceiptBUS.loadReceipt();
        }

        private void uc_KT_ManageReceipt_Load(object sender, EventArgs e)
        {
            dtgvResult.DataSource = ManageReceiptBUS.loadReceipt();
            var btnCol = new DataGridViewButtonColumn
            {
                Name = "btnAction",
                HeaderText = "Hành động",
                Text = "Tạo phiếu thu",
                UseColumnTextForButtonValue = true
            };
            dtgvResult.Columns.Add(btnCol);
        }

        private void dtgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvResult.ClearSelection();
        }
    }
}
