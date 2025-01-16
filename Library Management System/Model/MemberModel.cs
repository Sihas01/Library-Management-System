using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace Library_Management_System.Model
{
    internal class MemberModel
    {
        public bool CreateUser(string name, string email,string phoneNumber)
        {
            var member = new Member( name, email, phoneNumber);

         


            return true;
        }

        public List<Member> GetMembers() 
        {
            

                
            
        }

        public Member GetMember(string name) {
           
                
            
        }

        public bool UpdatePassword(Member member)
        {
           
        }
    }
}
