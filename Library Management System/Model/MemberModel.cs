using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BCrypt.Net;
using Library_Management_System.DAO;
using Library_Management_System.db;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System.Model
{
    internal class MemberModel
    {
        private readonly MemberDAO _memberDAO;

        public MemberModel()
        {
            _memberDAO = new MemberDAO();
        }

        public bool CreateUser(string name, string email,string phoneNumber)
        {
            var member = new Member(name, email, phoneNumber);
            return _memberDAO.CreateMember(member);
        }

        public List<Member> GetMembers()
        {
            return _memberDAO.GetMembers();

        }

        public Member GetMember(string email,string password) {
            var member = _memberDAO.GetMemberByEmail(email);
            if (member != null && BCrypt.Net.BCrypt.Verify(password, member.Password))
            {
                return member;
            }
            return null;
        }

        public bool UpdatePassword(Member member,string newPassword)
        {

            return _memberDAO.UpdateMemberPassword(member, newPassword);

        }
    }
}
