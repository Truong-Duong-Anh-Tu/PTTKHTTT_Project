using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.BUS
{
    internal class ManageRenewalBUS
    {
        public static DataTable loadRenewal(string filterText)
        {
            DataTable dt = ManageRenewalDAO.getRenewal(filterText);
            return dt;
        }

        public static DataTable loadCreatedRenewal(string filterText)
        {
            DataTable dt = ManageRenewalDAO.getCreatedRenewal(filterText);
            return dt;
        }

        public static Dictionary<string, string> getRenewalInfoPreview(string receiptId)
        {
            Dictionary<string, string> renewalPreview = new Dictionary<string, string>();

            DataTable dt = ManageRenewalDAO.getRenewal(receiptId.Trim());
            var row = dt.Rows[0];

            renewalPreview["HoTen"] = row["HoTen"].ToString() ?? "Unknown";
            renewalPreview["KyThi"] = row["TenKyThi"].ToString() ?? "Unknown";

            renewalPreview["MaLichThiMoi"] = row["MaLichThiMoi"].ToString() ?? "Unknown";
            renewalPreview["NgayThiMoi"] = row.Field<DateTime>("NgayThiMoi").ToString("dd/MM/yyyy") ?? "Unknown";

            var timeSpan = row.Field<TimeSpan>("GioThi");
            renewalPreview["GioThi"] = timeSpan.ToString(@"hh\:mm");

            // Lấy ngày lập là hôm nay
            renewalPreview["NgayLap"] = DateTime.Now.ToString("dd/MM/yyyy");

            return renewalPreview;
        }

        public static void insertIntoCreatedRenewalsTable(string receiptId, string reason, decimal fee)
        {
            try
            {
                ManageRenewalDAO dao = new ManageRenewalDAO();
                dao.insertIntoCreatedRenewalsTableDAO(receiptId, reason, fee);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error inserting into created renewals table: " + ex.Message);
                throw;
            }
        }

        //Cap nhat thong tin phieu gia han dung phuong thuc chuyen khoan
        public static void updateCreatedRenewalMethod(string receiptId, string currentValue)
        {
            try
            {
                ManageRenewalDAO dao = new ManageRenewalDAO();
                dao.updateCreatedRenewalMethodDAO(receiptId, currentValue);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating created renewal method: " + ex.Message);
                throw;
            }
        }

        //Cap nhat thong tin phieu gia han da duoc thanh toan
        public static void updateCreatedRenewalPaid(string receiptId, string currentValue)
        {
            try
            {
                ManageRenewalDAO dao = new ManageRenewalDAO();
                dao.updateCreatedRenewalPaidDAO(receiptId, currentValue);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating created renewal paid status: " + ex.Message);
                throw;
            }
        }
    }
}
