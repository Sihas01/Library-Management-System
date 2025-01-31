using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;
using Library_Management_System.Services;
using Library_Management_System.View;

namespace Library_Management_System.Controller
{
    internal class AccountController
    {
        private readonly ILogin login;
        private readonly MemberModel member;
        private readonly Msg msg;

        private Member member1;

        public AccountController(ILogin login)
        {
            this.login = login;
            member = new MemberModel();
        }

        public AccountController(Msg msg)
        {
            this.msg = msg;
            member = new MemberModel();
        }

        public void Login()
        {
            try
            {
                string name = login.Name.ToLower();
                string password = login.Password;

                //UserValidation.ValidateName(name);
                //UserValidation.ValidatePassword(password);

                member1 = member.GetMember(name,password);
                if (member1 != null) 
                    {
                    LoggedInUser.Instance.CurrentUser = member1;
                    login.ShowMessage("User Found");

                    if(member1.HasChangedPassword == false)
                    {
                        
                        Msg msg = new Msg();
                        msg.Show();

                    }
                    else
                    {
                        login.ShowMessage("memeber");
                        MemberDashboard memberDashboard = new MemberDashboard();
                        memberDashboard.Show();

                    }
                }
                else
                {
                    login.ShowMessage("Invalid User");
                }
            }
            catch (ArgumentException ex)
            {
                login.ShowMessage($"Error: {ex.Message}");
            }
            catch (Exception e)
            {
                login.ShowMessage($"Unexpected error: {e.Message}");
            }
        }

        public void Update()
        {
            try
            {
                Member member1 = LoggedInUser.Instance.CurrentUser;
                if (member1 != null)
                {
                    string password = msg.Password;
                    UserValidation.ValidatePassword(password);
                    
                    bool isUpdated =  member.UpdatePassword(member1,password);
                    if (isUpdated) {
                        msg.Hide();
                    }
                    else
                    {
                        msg.ShowMessage("Failed to update password. Member not found.");
                    }

                }
                else
                {
                    msg.ShowMessage("memeber not found");
                }
            }
            catch (ArgumentException ex)
            {
                msg.ShowMessage($"Error: {ex.Message}");
            }
            catch (Exception e)
            {
                msg.ShowMessage($"Unexpected error: {e.Message}");
            }
        }
    }
}
