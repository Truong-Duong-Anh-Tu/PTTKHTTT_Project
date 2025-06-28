using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    public class NhanVienBUS
    {
        public static DataTable GetAllNhanVien()
        {
            return NhanVienDAO.GetAllNhanVien();
        }
        
        public static DataTable SearchNhanVien(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAllNhanVien();
            
            return NhanVienDAO.SearchNhanVien(searchTerm);
        }
    }
}