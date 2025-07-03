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
        private string username;
        public fKT_CreateReceipt_Preview(string inputReceiptID, string accessUser)
        {
            InitializeComponent();
            receiptID = inputReceiptID;
            username = accessUser;
        }

        private void fKT_CreateReceipt_Preview_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> receiptPreview = ManageReceiptBUS.getReceiptInfoPreview(receiptID);

            txbHoTen.Text = receiptPreview["HoTen"];
            txbMaKH.Text = receiptPreview["MaKH"];
            txbNoiDung.Text = receiptPreview["NoiDung"];
            txbSoTienThu.Text = receiptPreview["SoTienThu"];
            txbNgayThu.Text = receiptPreview["NgayThu"];

            var bus = new NhanVienBUS(username);

            Dictionary<string, string> temp = bus.getInfoOfUser();
            txbNguoiThu.Text = "Kế toán " + temp["Hoten"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the form without saving
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have the necessary parameters to call this method
                ManageReceiptBUS.insertIntoPaycheckTable(receiptID, username, int.Parse(txbSoTienThu.Text), txbGhiChu.Text);
                MessageBox.Show("Phiếu thu đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo phiếu thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
