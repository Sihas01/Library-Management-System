using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Google.Protobuf.WellKnownTypes;
using Library_Management_System.Services;

namespace Library_Management_System.Model
{
    public class Member:Person
    {
        private string _hashedPassword;
        private bool _hasChangedPassword;
        public Member() { }
        public Member(string name,string email,string phoneNumber):base(name,email,phoneNumber) 
        {
            var generatedPassword = PasswordGenerator.GenerateNewPassword();
            _hashedPassword = Hashedpassword(generatedPassword);
            _hasChangedPassword = false;
        }

        public string Password
        {
            get { return _hashedPassword; }
            set { _hashedPassword = value; }

        }

        public bool HasChangedPassword
        {
            get { return _hasChangedPassword; }
            set { _hasChangedPassword = value ; }

        }

        private string Hashedpassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
         }

        public void UpdatePassword(string password)
        {
            Password = Hashedpassword(password);
            HasChangedPassword = true;
        }
       

    }
}
