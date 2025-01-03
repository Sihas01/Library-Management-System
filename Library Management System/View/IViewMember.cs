using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;

namespace Library_Management_System.View
{
    internal interface IViewMember
    {
       
        void ShowMessage(string message);

        // Modify to accept the list of members and display them
        void DisplayMembers(List<Member> members);
    }
}
