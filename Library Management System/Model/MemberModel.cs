using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.db;
using Microsoft.VisualBasic.ApplicationServices;

namespace Library_Management_System.Model
{
    internal class MemberModel
    {
        public bool CreateUser(string name, string email,string phoneNumber, string password)
        {
            var member = new Member( name, email, phoneNumber, password);

            using (var context = new AppDbContext())
            {
                context.Members.Add(member);
                context.SaveChanges();
            }


            return true;
        }

        public List<Member> GetMembers() 
        {
            using (var context = new AppDbContext()) 
            {
                var members = context.Members.ToList();

                return members;
            }
        }
    }
}
