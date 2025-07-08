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
    }
}
