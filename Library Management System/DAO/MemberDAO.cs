using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.db;
using Library_Management_System.Model;

namespace Library_Management_System.DAO
{
    internal class MemberDAO
    {
        private readonly Database _database;

        public MemberDAO()
        {
            _database = new Database();
        }

        public bool CreateMember(Member member)
        {
            try
            {
                var columns = new List<string> { "name", "email", "phonenumber", "password", "hasChangedPassword" ,"finesDue","role"};
                var values = new List<object>
                {
                    member.Name,
                    member.Email,
                    member.PhoneNumber,
                    member.Password,
                    member.HasChangedPassword ? 1 : 0,
                    member.FinesDeu,
                    member.Role
                };

                _database.Insert("member", columns, values);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Member> GetMembers()
        {
            try
            {
                var members = new List<Member>();
                var result = _database.Select("member");

                foreach (var row in result)
                {
                    var member = new Member(row["name"], row["email"], row["phonenumber"])
                    {
                        Password = row["password"],
                        HasChangedPassword = row["hasChangedPassword"] == "1",
                        Id = Convert.ToInt32(row["id"])
                    };
                    members.Add(member);
                }

                return members;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving members.", ex);
            }
        }

        public Member GetMemberByEmail(string email)
        {
            try
            {
                var members = _database.Select("member", "*", $"email = '{email}'");
                if (members != null && members.Count > 0)
                {
                    var memberData = members[0];
                    return new Member
                    {
                        Name = memberData["name"],
                        Email = memberData["email"],
                        PhoneNumber = memberData["phonenumber"],
                        Password = memberData["password"],
                        HasChangedPassword = memberData["hasChangedPassword"] == "1"
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving member by email.", ex);
            }
        }

        public bool UpdateMemberPassword(Member member, string newPassword)
        {
            try
            {
                member.UpdatePassword(newPassword);
                List<string> setClauses = new List<string>
                {
                    $"password = '{member.Password}'",
                    $"hasChangedPassword = 1"
                };
                string condition = $"email = '{member.Email}'";
                _database.Update("member", setClauses, condition);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void UpdateMemeber(Member member)
        {
            try
            {
                List<string> columns = new List<string> { "name", "phonenumber" };
                List<string> setClauses = new List<string>
                {
                   $"name = '{member.Name}'",
                   $"phonenumber = '{member.PhoneNumber}'",
                };
                string condition = $"email = '{member.Email}'";
                _database.Update("member", setClauses, condition);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error updating member by email.", ex);
            }
        }
    }
}
