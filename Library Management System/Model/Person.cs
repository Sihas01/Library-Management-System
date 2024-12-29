using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    internal class Person
    {
        private string _id;
        private string _name;
        private string _email;
        private string _phoneNumber;

        public Person(string id, string name, string email, string phoneNumber)
        {
            _id = id;
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
}
