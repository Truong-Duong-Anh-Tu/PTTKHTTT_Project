using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    public class PhongThiBUS
    {
        public static DataTable GetAllPhongThi()
        {
            return PhongThiDAO.GetAllPhongThi();
        }
    }
}