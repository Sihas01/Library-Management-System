using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;

namespace Library_Management_System.Services
{
    internal class LoggedInUser
    {
        private static LoggedInUser _instance;

        private LoggedInUser() { }

        public Member CurrentUser { get; set; }

        public static LoggedInUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoggedInUser();
                }
                return _instance;
            }
        }
    }
}
