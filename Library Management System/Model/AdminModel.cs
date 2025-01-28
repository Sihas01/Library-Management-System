using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.DAO;

namespace Library_Management_System.Model
{
    internal class AdminModel
    {
        private readonly AdminDAO _adminDAO;

        public AdminModel()
        {
            _adminDAO = new AdminDAO();
        }

        public Admin GetAdmin(string email, string password)
        {
            var admin = _adminDAO.GetAdminByEmail(email);
            if (admin != null && BCrypt.Net.BCrypt.Verify(password, admin.Password))
            {
                return admin;
            }
            return null;
        }
    }
}
