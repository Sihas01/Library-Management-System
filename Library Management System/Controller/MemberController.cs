using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;
using Library_Management_System.Services;
using Library_Management_System.View;
using Microsoft.VisualBasic.ApplicationServices;

namespace Library_Management_System.Controller
{
    internal class MemberController
    {
        private readonly IMemberView _memberView;
        private readonly MemberModel _memberModel;
        private readonly ViewMember viewMember;
        private readonly EmailController emailController;

        public MemberController(IMemberView memberView)
        {
            _memberView = memberView;
            _memberModel = new MemberModel();
            emailController = new EmailController();
        }

        public MemberController(ViewMember viewMember)
        {
            this.viewMember = viewMember;
            _memberModel = new MemberModel();
        }

        public void CreateUser()
        {
            try
            {
                string name = _memberView.Name;
                string email = _memberView.Email;
                string phoneNumber = _memberView.PhoneNumber;
               

                UserValidation.ValidateUser(name, email, phoneNumber);

                var result = _memberModel.CreateUser(name, email,phoneNumber);
                bool isSuccess = result.Item1;
                string generatedPassword = result.Item2;

                if (isSuccess)
                {
                    string message = emailController.SendEmail(email, "Welcome to Our Service!", $"Hello {name},\nWelcome to our service!\n Use this for first Login : {generatedPassword}");
                    
                    _memberView.ShowMessage(message);
                    _memberView.ShowMessage("User created successfully");
                }
                else
                {
                    _memberView.ShowMessage("Faild to create user");
                }
            }
            catch (ArgumentException ex)
            {
                _memberView.ShowMessage($"Error: {ex.Message}");
            }
            catch (Exception e)
            {
                _memberView.ShowMessage($"Unexpected error: {e.Message}");
            }
        }

        public List<Member> GetUser()
        {
            try
            {

                var members = _memberModel.GetMembers();


                viewMember.DisplayMembers(members);

                return members;
            }
            catch (Exception e)
            {
                viewMember.ShowMessage($"Error fetching members: {e.Message}");
                return new List<Member>();
            }
        }
    }
}
