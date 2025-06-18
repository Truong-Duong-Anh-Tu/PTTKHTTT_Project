using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class TaiKhoanBUS
    {
        public static bool DangNhap(string username, string password)
        {
            username = username.Trim();
            password = password.Trim();

            return TaiKhoanDAO.checkLogin(username, password);
        }
    }
}
