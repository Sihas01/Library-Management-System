using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    internal class Admin:Person
    {
        private string _role;
        public Admin(string name, string email, string phoneNumber):base(name, email, phoneNumber) {
            _role = "admin";
        }

        public Admin() { }

    }
}
