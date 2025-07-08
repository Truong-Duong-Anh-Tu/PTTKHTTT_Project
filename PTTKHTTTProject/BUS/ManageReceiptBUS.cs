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

        public static DataTable loadPaycheck(string filterText)
        {
            DataTable dt = ManageReceiptDAO.getPaycheck(filterText);
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

        public static void insertIntoPaycheckTable(string receiptId, string employeeId, decimal fee, string notes)
        {
            try
            {
                ManageReceiptDAO dao = new ManageReceiptDAO();
                dao.insertIntoPaycheckTableDAO(receiptId, employeeId, fee, notes);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error inserting into paycheck table: " + ex.Message);
                throw;
            }
        }

        //Cap nhat thong tin phieu thu dung phuong thuc chuyen khoan
        public static void updatePaycheckMethod(string receiptId, string currentValue)
        {
            try
            {
                ManageReceiptDAO dao = new ManageReceiptDAO();
                dao.updatePaycheckMethodDAO(receiptId, currentValue);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating paycheck method: " + ex.Message);
                throw;
            }
        }

        //Cap nhat thong tin phieu thu da duoc thanh toan
        public static void updatePaycheckPaid(string receiptId, string currentValue)
        {
            try
            {
                ManageReceiptDAO dao = new ManageReceiptDAO();
                dao.updatePaycheckPaidDAO(receiptId, currentValue);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating paycheck paid status: " + ex.Message);
                throw;
            }
        }
    }
}
