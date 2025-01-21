using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;

namespace Library_Management_System.View
{
    internal interface IMemberView
    {
        string Name { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        void ShowMessage(string message);

        void DisplayMembers(List<Member> members);
    }
}
