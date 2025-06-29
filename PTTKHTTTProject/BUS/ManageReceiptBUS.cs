using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class ManageReceiptBUS
    {
        public static DataTable loadReceipt(string filterText)
        {
            DataTable dt = ManageReceiptDAO.getReceipt(filterText);
            return dt;
        }

        //Xem thong tin cua mot phieu thu cu the
        public static Dictionary<string, string> getReceiptInfoPreview(string receiptId)
        {
            Dictionary<string, string> receiptPreview = new Dictionary<string, string>();

            DataTable dt = ManageReceiptDAO.getReceipt(receiptId.Trim());
            var row = dt.Rows[0];

            receiptPreview["HoTen"] = row["HoTen"].ToString() ?? "Unknown";
            receiptPreview["MaKH"] = row["MaKhachHang"].ToString() ?? "Unknown";
            receiptPreview["NoiDung"] = "Thu lệ phí " + row["TenKyThi"].ToString() ?? "Unknown";
            receiptPreview["SoTienThu"] = row["LePhi"].ToString() ?? "Unknown";
            receiptPreview["NgayThu"] = DateTime.Now.ToString("dd/MM/yyyy");

            return receiptPreview;
        }
    }
}
