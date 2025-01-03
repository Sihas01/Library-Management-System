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
    internal class MemberController
    {
        private readonly IMemberView _memberView;
        private readonly MemberModel _memberModel;
        private readonly ViewMember viewMember;

        public MemberController(IMemberView memberView)
        {
            _memberView = memberView;
            _memberModel = new MemberModel();
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
                string password = _memberView.Password;

                UserValidation.ValidateUser(name, email, phoneNumber, password);

                bool success = _memberModel.CreateUser(name, email,phoneNumber, password);

                if (success)
                {
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
                // Fetching members from the model (using Entity Framework)
                var members = _memberModel.GetMembers();

                // Passing the list of members to the view's DisplayMembers method
                viewMember.DisplayMembers(members);

                return members; // Return the list of members
            }
            catch (Exception e)
            {
                viewMember.ShowMessage($"Error fetching members: {e.Message}");
                return new List<Member>(); // Return an empty list on error
            }
        }
    }
}
