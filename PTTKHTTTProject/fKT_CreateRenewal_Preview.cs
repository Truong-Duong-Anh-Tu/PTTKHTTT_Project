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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTKHTTTProject
{
    public partial class fKT_CreateRenewal_Preview : Form
    {
        private string receiptID;
        private string username;

        public fKT_CreateRenewal_Preview(string inputReceiptID, string accessUser)
        {
            InitializeComponent();
            receiptID = inputReceiptID;
            username = accessUser;
        }

        private void fKT_CreateRenewal_Preview_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> renewalInfo = ManageRenewalBUS.getRenewalInfoPreview(receiptID);

            txbHoTen.Text = renewalInfo["HoTen"];
            txbNoiDung.Text = renewalInfo["KyThi"];
            //txbSoTienThu.Text = renewalInfo["SoTien"];

            txbNgayThiGH.Text = renewalInfo["MaLichThiMoi"] + " - " + renewalInfo["NgayThiMoi"] + " - " + renewalInfo["GioThi"];

            txbNgayLap.Text = renewalInfo["NgayLap"];
            var bus = new InfoEmployeeBUS(username);

            Dictionary<string, string> temp = bus.getInfoOfUser();
            txbNguoiLap.Text = "Kế toán " + temp["Hoten"];
        }

        //Hủy tạo phiếu gia hạn
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Xác nhận tạo phiếu gia hạn
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have the necessary parameters to call this method
                ManageRenewalBUS.insertIntoCreatedRenewalsTable(receiptID, txbLyDo.Text, Convert.ToDecimal(txbLePhi.Text));
                MessageBox.Show("Phiếu gia hạn đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo phiếu gia hạn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
