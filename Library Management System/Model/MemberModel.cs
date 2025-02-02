using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BCrypt.Net;
using Library_Management_System.DAO;
using Library_Management_System.db;
using Library_Management_System.View;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System.Model
{
    internal class MemberModel
    {
        private readonly MemberDAO _memberDAO;
        private readonly BorrowingRecodModel _borrowingRecodModel;

        public MemberModel()
        {
            _memberDAO = new MemberDAO();
            _borrowingRecodModel = new BorrowingRecodModel();
        }

        public (bool, string) CreateUser(string name, string email,string phoneNumber)
        {
            var exsistingMember = _memberDAO.GetMemberByEmail(email);
            if (exsistingMember == null)
            {
                var member = new Member(name, email, phoneNumber);
                bool isSuccess = _memberDAO.CreateMember(member);
                string generatedPassword = member.GeneratedPassword;
                return (isSuccess, generatedPassword);
            }
            else
            {
                return (false, null);
            }
            
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

        public Member GetMemberByEmail(string email)
        {
            var member = _memberDAO.GetMemberByEmail(email);
            if(member != null)
            {
                return member;
            }
            return null;
        }

        public bool UpdatePassword(Member member,string newPassword)
        {

            return _memberDAO.UpdateMemberPassword(member, newPassword);

        }

        public void UpdateMember(Member member)
        {
            _memberDAO.UpdateMemeber(member);
        }

        public bool DeleteMember(string email) {
            Member member =  GetMemberByEmail(email);
            if (member != null)
            {
                var result = _borrowingRecodModel.Getborrowedbooks(member.Id);
                if (result == null || result.Count == 0)
                {
                    _memberDAO.DeleteMember(email);
                    return true;
                }
                
            }
            return false;
        }

        public List<ActiveMember> GetMostActiveMembers()
        {
            return _memberDAO.GetMostActiveMembers();
        }
    }
}
