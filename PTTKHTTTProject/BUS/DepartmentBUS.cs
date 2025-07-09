using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class DepartmentBUS
    {
        private string _departmentCode;
        private string _departmentName;
        public DepartmentBUS(string departmentCode)
        {
            _departmentCode = departmentCode;
            _departmentName = DepartmentDAO.getDepartmentName(_departmentCode);
        }

        public static List<string> getAllRecipientDepartment()
        {
            List<string> recipients = new List<string>();


            DataTable dt2 = DepartmentDAO.GetAllPhongBan();

            foreach (DataRow dr in dt2.Rows)
            {
                string temp = $"{dr["PB_MaPhongBan"].ToString()} - {dr["PB_TenPhongBan"].ToString()}";
                recipients.Add(temp);
            }

            return recipients;
        }

        public static DataTable GetAllPhongBan()
        {
            return DepartmentDAO.GetAllPhongBan();
        }

        public static string GetMaPhongBanByTen(string tenPhongBan)
        {
            if (string.IsNullOrWhiteSpace(tenPhongBan))
                return string.Empty;
            DataTable dt = DepartmentDAO.GetPhongBanByTenPhongBan(tenPhongBan);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["PB_MaPhongBan"].ToString() ?? string.Empty;
            return string.Empty;
        }
    }
}
