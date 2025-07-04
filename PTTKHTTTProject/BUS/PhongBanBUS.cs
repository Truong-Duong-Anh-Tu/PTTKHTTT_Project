using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;
namespace PTTKHTTTProject.BUS
{
    internal class PhongBanBUS
    {
        public static DataTable GetAllPhongBan()
        {
            return PhongBanDAO.GetAllPhongBan();
        }
    }
}
