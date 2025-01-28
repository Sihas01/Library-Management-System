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
    public class Member : Person
    {
        private bool _hasChangedPassword;
        private string generatedPassword;
        private double _finesDeu;
        public Member() { }
        public Member(string name, string email, string phoneNumber) : base(name, email, phoneNumber)
        {
            generatedPassword = PasswordGenerator.GenerateNewPassword();
            _hashedPassword = Hashedpassword(generatedPassword);
            _hasChangedPassword = false;
            _finesDeu = 0;
        }

        public bool HasChangedPassword
        {
            get { return _hasChangedPassword; }
            set { _hasChangedPassword = value; }

        }

        public double FinesDeu
        {
            get { return _finesDeu; }
            set { _finesDeu = value; }
        }

        public void UpdatePassword(string password)
        {
            Password = Hashedpassword(password);
            HasChangedPassword = true;
        }

        public string GeneratedPassword
        {
            get { return generatedPassword; }
        }
    }
}
