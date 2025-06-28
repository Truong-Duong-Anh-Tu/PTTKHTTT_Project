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
        public static bool checkSignIn(string email, string password)
        {
            email = email.Trim();
            password = password.Trim();

            string storedPassword = TaiKhoanDAO.getAccount(email);

            if (storedPassword == String.Empty)
            {
                return false;
            }

            return BCrypt.Net.BCrypt.Verify(password, storedPassword);
        }

        public static string getUsername(string email)
        {
            string username = TaiKhoanDAO.getUsername(email);

            return username;
        }

        public static string CheckRole(string username)
        {
            string role = TaiKhoanDAO.getRole(username);

            return role;
        }
    }
}
