using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace Library_Management_System.Model
{
    internal class MemberModel
    {
        public bool CreateUser(string name, string email,string phoneNumber)
        {
            var member = new Member( name, email, phoneNumber);

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
                var members = context.Members
                    .Select(m => new Member
                    {
                        Id = m.Id,
                        Name = m.Name,
                        Email = m.Email,
                        PhoneNumber = m.PhoneNumber,
                    })
                    .ToList();

                return members;
            }
        }

        public Member GetMember(string name) {
            using (var context = new AppDbContext())
            {
                var user = context.Members
                .FirstOrDefault(m => m.Name == name);

                return user ;
            }
                
            
        }

        public bool UpdatePassword(Member member)
        {
            try
            {
                if(member == null)
                {
                    throw new ArgumentNullException(nameof(member), "Member cannot be null.");
                }

                using (var context = new AppDbContext())
                {
                    var existingMember = context.Members.FirstOrDefault(m => m.Name == member.Name);
                    if (existingMember != null)
                    {
                        existingMember.Password = member.Password;
                        existingMember.HasChangedPassword = true;


                        context.SaveChanges();
                        return true;

                    }
                    else
                    {
                        throw new InvalidOperationException("Member not found.");
                    }
                }
                  
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("sdfdf");
            }
        }
    }
}
