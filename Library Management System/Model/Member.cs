using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Library_Management_System.Model
{
    public class Member:Person
    {
        private string _hashedPassword;
        public Member() { }
        public Member(string name,string email,string phoneNumber,string password):base(name,email,phoneNumber) 
        {
            _hashedPassword = Hashedpassword( password);
        }

        public string Password
        {
            get { return _hashedPassword; }
            set { _hashedPassword = Hashedpassword(value); }

        }

        private string Hashedpassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
         }

       

    }
}
