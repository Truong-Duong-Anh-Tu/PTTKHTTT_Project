using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject
{
    public partial class fKT_CreateReceipt_Preview : Form
    {
        private string receiptID;
        public fKT_CreateReceipt_Preview(string inputReceiptID)
        {
            InitializeComponent();
            receiptID = inputReceiptID;
        }

        private void fKT_CreateReceipt_Preview_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> receiptInfo = ManageReceiptBUS.getReceiptInfoPreview(receiptID);

            txbHoTen.Text = receiptInfo["HoTen"];
            txbNoiDung.Text = receiptInfo["KyThi"];
            txbSoTienThu.Text = receiptInfo["SoTien"];
        }
    }
}
