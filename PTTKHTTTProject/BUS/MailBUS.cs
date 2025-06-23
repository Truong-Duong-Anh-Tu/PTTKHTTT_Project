using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class MailBUS
    {
        public static List<Dictionary<string, string>> getListMail(string username)
        {
            List<Dictionary<string, string>> listMail = new List<Dictionary<string, string>>();

            DataTable dt = MailDAO.LoadReceiveMail(username.Trim());

            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, string> temp = new Dictionary<string, string>();

                temp["TB_MaNhanVienGui"] = dr["TB_MaNhanVienGui"].ToString() ?? "Unknown";
                temp["TB_ChuDe"] = dr["TB_ChuDe"].ToString() ?? "Unknown";
                temp["TB_NoiDung"] = dr["TB_NoiDung"].ToString() ?? "Unknown";
                temp["TB_ThoiGianGui"] = dr["TB_ThoiGianGui"] == DBNull.Value
                                            ? "Unknown"
                                            : ((DateTime)dr["TB_ThoiGianGui"])
                                                .ToString("dd/MM/yyyy HH:mm:ss");

                listMail.Add(temp);
            }

            listMail = listMail.OrderByDescending(dict => ParseOrMin(dict["TB_ThoiGianGui"])).ToList();

            return listMail;
                
        }

        private static DateTime ParseOrMin(string s)
        {
            if (DateTime.TryParseExact(
                    s,
                    "dd/MM/yyyy HH:mm:ss",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out var dt))
            {
                return dt;
            }
            return DateTime.MinValue;
        }

        public static List<string> LoadRecipients(string type)
        {
            List<string> recipients = new List<string>();

            if (!string.IsNullOrEmpty(type) && type == "PhongBan")
            {
                DataTable dt2 = MailDAO.GetDepartment();

                foreach (DataRow dr in dt2.Rows)
                {
                    string temp = $"{dr["PB_MaPhongBan"].ToString()} - {dr["PB_TenPhongBan"].ToString()}";
                    recipients.Add(temp);
                }
            }

            else if (!string.IsNullOrEmpty(type) && type == "NhanVien")
            {

                DataTable dt1 = MailDAO.GetRecipients();

                foreach (DataRow dr in dt1.Rows)
                {
                    string temp = $"{dr["NV_MaNhanVien"].ToString()} - {dr["NV_TenNhanVien"].ToString()} - {dr["NV_ChucVu"].ToString()}";
                    recipients.Add(temp);
                }
            }

            else
            {
                return recipients;
            } 
                
            return recipients;
        }

        public static void sendNotification(string usender, string recipient, string subject, string body)
        {
            MailDAO.sendNotification(usender, recipient, subject, body);
        }
    }
}
