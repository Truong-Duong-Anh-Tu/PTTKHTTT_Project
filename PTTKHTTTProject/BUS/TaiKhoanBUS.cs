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
        private string _email;
        private string _password;

        public TaiKhoanBUS(string email, string password)
        {
            _email = email.Trim();
            _password = password.Trim();
        }

        public bool checkSignIn()
        {
            string storedPassword = TaiKhoanDAO.getAccount(_email);

            if (storedPassword == String.Empty)
            {
                return false;
            }

            return BCrypt.Net.BCrypt.Verify(_password, storedPassword);
        }

        public string getUsername()
        {
            string username = TaiKhoanDAO.getUsername(_email);

            return username;
        }

        public string CheckRole(string username)
        {
            string role = TaiKhoanDAO.getRole(username);

            return role;
        }
    }
}
