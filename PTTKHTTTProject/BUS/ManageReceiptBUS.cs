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
        public static Dictionary<string, string> getReceiptInfoPreview(string receiptId)
        {
            Dictionary<string, string> receiptPreview = new Dictionary<string, string>();

            DataTable dt = ManageReceiptDAO.getReceipt(receiptId.Trim());
            var row = dt.Rows[0];

            receiptPreview["HoTen"] = row["HoTen"].ToString() ?? "Unknown";
            receiptPreview["KyThi"] = row["MaKyThi"].ToString() ?? "Unknown";
            receiptPreview["SoTien"] = row["LePhi"].ToString() ?? "Unknown";
            
            //receiptPreview["SoBaoDanh"] = row["TS_SoBaoDanh"].ToString() ?? "Unknown";
            //receiptPreview["MaPhieu"] = row["PDKDT_MaPhieu"].ToString() ?? "Unknown";
            //receiptPreview["NgayLap"] = Convert.ToDateTime(row["PDKDT_NgayLap"]).ToString("dd/MM/yyyy") ?? "Unknown";
            
            return receiptPreview;
        }
    }
}
