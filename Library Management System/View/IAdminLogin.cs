using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.View
{
    internal interface IAdminLogin
    {
        string Name { get; set; }
        string Password { get; set; }


        void ShowMessage(string message);
    }
}
