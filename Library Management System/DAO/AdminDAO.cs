using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.db;
using Library_Management_System.Model;

namespace Library_Management_System.DAO
{
    internal class AdminDAO
    {
        private readonly Database _database;

        public AdminDAO()
        {
            _database = new Database();
        }

        public Admin GetAdminByEmail(string email)
        {
            try
            {
                var admins = _database.Select("admin", "*", $"email = '{email}'");
                if (admins != null && admins.Count > 0)
                {
                    var adminData = admins[0];
                    return new Admin
                    {
                        Name = adminData["name"],
                        Email = adminData["email"],
                        PhoneNumber = adminData["phonenumber"],
                        Password = adminData["password"],
                        Role = adminData["role"]
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving admin by email.", ex);
            }
        }
    }
}
