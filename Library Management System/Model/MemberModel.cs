using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BCrypt.Net;
using Library_Management_System.db;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System.Model
{
    internal class MemberModel
    {
        private readonly Database database;

        public MemberModel()
        {
            database = new Database();
        }

        public bool CreateUser(string name, string email,string phoneNumber)
        {
            try
            {
                var columns = new List<string> { "name", "email", "phonenumber", "password", "hasChangedPassword" };
                var member = new Member(name, email, phoneNumber);
                var values = new List<object>
            {
                member.Name,
                member.Email,
                member.PhoneNumber,
                member.Password,
                0
            };
                database.Insert("members", columns, values);

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
                var result = database.Select("members");
                foreach (var row in result)
                {
                    var member = new Member(
                        row["name"],
                        row["email"],
                        row["phonenumber"]
                    )
                    {
                        Password = row["password"],
                        HasChangedPassword = row["hasChangedPassword"] == "1",
                        Id = Convert.ToInt32( row["id"])
                    };

                    members.Add(member);
                    
                }
                return members;
            }
            catch (Exception ex)
            {
               throw ex;    
            }

            return null;

        }

        public Member GetMember(string name,string password) {
            Member returnMember = null;

            var members = database.Select("members", "*", $"email = '{name}'");
            if (members != null && members.Count > 0)
            {
                var memberData = members[0]; 

               
                string storedPassword = memberData["password"]; 

                if (BCrypt.Net.BCrypt.Verify(password, storedPassword))
                {
                    returnMember = new Member
                    {
                        Name = memberData["name"], 
                        Email = memberData["email"],
                        PhoneNumber = memberData["phonenumber"],
                        Password = storedPassword,
                        HasChangedPassword = memberData["hasChangedPassword"] == "1"
                    };
                }
            }

            return returnMember;
        }

        public bool UpdatePassword(Member member,string newPassword)
        {

            var members = database.Select("members", "*", $"email = '{member.Email}'");
            if (members != null && members.Count > 0)
            { 
            member.UpdatePassword(newPassword);
                List<string> setClauses = new List<string>
                {
                    $"password = '{member.Password}'"
                };

                string condition = $"Email = '{member.Email}'";

                database.Update("members", setClauses, condition);

                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
