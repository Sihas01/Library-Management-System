using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BCrypt.Net;
using Library_Management_System.db;
using Microsoft.VisualBasic.ApplicationServices;

namespace Library_Management_System.Model
{
    internal class MemberModel
    {
        private readonly DatabaseHelper dbHelper;

        public MemberModel()
        {
            dbHelper = new DatabaseHelper();
        }

        public bool CreateUser(string name, string email,string phoneNumber)
        {
            var member = new Member( name, email, phoneNumber);

         
            dbHelper.InsertMember(member);

            return true;
        }

        //public List<Member> GetMembers() 
        //{
            

                
            
        //}

        public Member GetMember(string name,string password) {

            Member returnMember = null;
           
               var member = dbHelper.ViewMember(name);
            if(member != null && BCrypt.Net.BCrypt.Verify(password, member.Password)  )
            {
                returnMember = member;
            }

            return returnMember;
        }

        public bool UpdatePassword(Member member,string newPassword)
        {
            var memberDetails = dbHelper.ViewMember(member.Email);
            if(memberDetails != null)
            {
                memberDetails.UpdatePassword(newPassword);
                dbHelper.UpdateMemberPassword(memberDetails);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
