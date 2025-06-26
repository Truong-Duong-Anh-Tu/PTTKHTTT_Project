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
        public static bool checkSignIn(string username, string password)
        {
            username = username.Trim();
            password = password.Trim();

            string storedPassword = TaiKhoanDAO.getAccount(username);

            if (storedPassword == String.Empty)
            {
                return false;
            }

            return BCrypt.Net.BCrypt.Verify(password, storedPassword);
        }

        public static string CheckRole(string username)
        {
            string role = TaiKhoanDAO.getRole(username);

            return role;
        }
    }
}
