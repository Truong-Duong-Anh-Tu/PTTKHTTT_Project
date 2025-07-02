using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static Dictionary<string, string> getRenewalInfoPreview(string receiptId)
        {
            Dictionary<string, string> renewalPreview = new Dictionary<string, string>();

            DataTable dt = ManageRenewalDAO.getRenewal(receiptId.Trim());
            var row = dt.Rows[0];

            renewalPreview["HoTen"] = row["HoTen"].ToString() ?? "Unknown";
            renewalPreview["KyThi"] = row["TenKyThi"].ToString() ?? "Unknown";
            renewalPreview["SoBaoDanh"] = row["SoBaoDanh"].ToString() ?? "Unknown";

            //renewalPreview["SoTien"] = row["LePhi"].ToString() ?? "Unknown";

            //receiptPreview["SoBaoDanh"] = row["TS_SoBaoDanh"].ToString() ?? "Unknown";
            //receiptPreview["MaPhieu"] = row["PDKDT_MaPhieu"].ToString() ?? "Unknown";
            //receiptPreview["NgayLap"] = Convert.ToDateTime(row["PDKDT_NgayLap"]).ToString("dd/MM/yyyy") ?? "Unknown";

            return renewalPreview;
        }
    }
}
