using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    internal class Member:Person
    {
        private string _password;
        public Member(string memberId,string name,string email,string phoneNumber,string password):base(memberId,name,email,phoneNumber) 
        { 
            _password = password;
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }

        }

        
    }
}
