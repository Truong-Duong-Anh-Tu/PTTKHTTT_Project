using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class MailBUS
    {
        private string _username;
        public MailBUS(string accessUser)
        {
            _username = accessUser;
        }

        public List<Dictionary<string, string>> loadListMailReceive()
        {
            List<Dictionary<string, string>> listMail = new List<Dictionary<string, string>>();

            string department = TaiKhoanDAO.getRole(_username);

            DataTable dt = MailDAO.getReceiveMail(_username.Trim(), department.Trim());

            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, string> temp = new Dictionary<string, string>();

                temp["MaNhanVienGui"] = dr["TB_MaNhanVienGui"].ToString() ?? "Unknown";
                temp["VaiTroNVGui"] = TaiKhoanDAO.getRole(temp["MaNhanVienGui"]);

                temp["MaDoiTuongNhan"] = dr["TB_MaDoiTuongNhan"].ToString() ?? "Unknown";
                if (temp["MaDoiTuongNhan"].Contains("PB"))
                {
                    temp["TenVTDoiTuong"] = DepartmentDAO.getDepartmentName(temp["MaDoiTuongNhan"]);
                }
                else
                {
                    temp["TenVTDoiTuong"] = TaiKhoanDAO.getRole(_username);
                }

                temp["ChuDe"] = dr["TB_ChuDe"].ToString() ?? "Unknown";
                temp["NoiDung"] = dr["TB_NoiDung"].ToString() ?? "Unknown";
                temp["ThoiGianGui"] = dr["TB_ThoiGianGui"] == DBNull.Value
                                            ? "Unknown"
                                            : ((DateTime)dr["TB_ThoiGianGui"])
                                                .ToString("dd/MM/yyyy HH:mm:ss");

                listMail.Add(temp);
            }

            listMail = listMail.OrderByDescending(dict => ParseOrMin(dict["ThoiGianGui"])).ToList();

            return listMail;    
        }

        public List<Dictionary<string, string>> loadListMailSend()
        {
            List<Dictionary<string, string>> listMail = new List<Dictionary<string, string>>();

            DataTable dt = MailDAO.getSendMail(_username.Trim());
            string rolesender = TaiKhoanDAO.getRole(_username.Trim());

            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, string> temp = new Dictionary<string, string>();

                temp["MaNhanVienGui"] = _username;
                temp["VaiTroNVGui"] = rolesender;

                temp["MaDoiTuongNhan"] = dr["TB_MaDoiTuongNhan"].ToString() ?? "Unknown";
                if (temp["MaDoiTuongNhan"].Contains("PB"))
                {
                    temp["TenVTDoiTuong"] = DepartmentDAO.getDepartmentName(temp["MaDoiTuongNhan"]);
                }
                else
                {
                    temp["TenVTDoiTuong"] = TaiKhoanDAO.getRole(temp["MaDoiTuongNhan"]);
                }    

                temp["ChuDe"] = dr["TB_ChuDe"].ToString() ?? "Unknown";
                temp["NoiDung"] = dr["TB_NoiDung"].ToString() ?? "Unknown";
                temp["ThoiGianGui"] = dr["TB_ThoiGianGui"] == DBNull.Value
                                            ? "Unknown"
                                            : ((DateTime)dr["TB_ThoiGianGui"])
                                                .ToString("dd/MM/yyyy HH:mm:ss");

                listMail.Add(temp);
            }

            listMail = listMail.OrderByDescending(dict => ParseOrMin(dict["ThoiGianGui"])).ToList();

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

        public static void sendNotification(string usender, string recipient, string subject, string body)
        {
            MailDAO.sendNotification(usender, recipient, subject, body);
        }
    }
}
