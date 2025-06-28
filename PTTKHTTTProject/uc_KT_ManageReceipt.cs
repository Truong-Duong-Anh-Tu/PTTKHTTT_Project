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
using PTTKHTTTProject.UControl;

namespace PTTKHTTTProject
{
    public partial class uc_KT_ManageReceipt : UserControl
    {
        public uc_KT_ManageReceipt()
        {
            InitializeComponent();
        }

        private void uc_KT_ManageReceipt_Load(object sender, EventArgs e)
        {
            dtgvResult.DataSource = ManageReceiptBUS.loadReceipt("");
            var btnCol = new DataGridViewButtonColumn
            {
                Name = "btnAction",
                HeaderText = "Hành động",
                Text = "Tạo phiếu thu",
                UseColumnTextForButtonValue = true
            };
            dtgvResult.Columns.Add(btnCol);

            //Clicking on button opens fKT_CreateReceipt_Preview form
            //Use getReceiptInfoPreview
            dtgvResult.CellContentClick += (s, ev) =>
            {
                var selectedReceiptID = dtgvResult.Rows[ev.RowIndex].Cells["PDKDT_MaPhieu"].Value.ToString();
                if (ev.ColumnIndex == dtgvResult.Columns["btnAction"].Index && ev.RowIndex >= 0)
                {
                    fKT_CreateReceipt_Preview previewForm = new fKT_CreateReceipt_Preview(selectedReceiptID);
                    previewForm.ShowDialog();
                }
            };

        }

        private void dtgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvResult.ClearSelection();
        }

        private void btnSearchReceipt_Click(object sender, EventArgs e)
        {
            if(txbInput.Text != string.Empty)
            {
                string filter = txbInput.Text.Trim().ToLower();
                dtgvResult.DataSource = ManageReceiptBUS.loadReceipt(filter);   
            }
            else
            {
                dtgvResult.DataSource = ManageReceiptBUS.loadReceipt("");
            }
        }
    }
}
