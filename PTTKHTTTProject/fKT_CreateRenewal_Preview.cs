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
    public partial class fKT_CreateRenewal_Preview : Form
    {
        private string receiptID;
        public fKT_CreateRenewal_Preview(string inputReceiptID)
        {
            InitializeComponent();
            receiptID = inputReceiptID;
        }

        private void fKT_CreateRenewal_Preview_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> renewalInfo = ManageRenewalBUS.getRenewalInfoPreview(receiptID);

            txbHoTen.Text = renewalInfo["HoTen"];
            txbNoiDung.Text = renewalInfo["KyThi"];
            //txbSoTienThu.Text = renewalInfo["SoTien"];
        }
    }
}
