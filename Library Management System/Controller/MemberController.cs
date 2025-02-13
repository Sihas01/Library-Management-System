﻿using System;
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
        private readonly EmailController emailController;
        private readonly ActiveMembers _activeMembers;

        public MemberController(IMemberView memberView)
        {
            _memberView = memberView;
            _memberModel = new MemberModel();
            emailController = new EmailController();
        }

        public MemberController(ActiveMembers activeMembers)
        {
            _activeMembers = activeMembers;
            _memberModel = new MemberModel();
        }

        public void CreateUser()
        {
            try
            {
                string name = _memberView.Name;
                string email = _memberView.Email.ToLower();
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
                    _memberView.ShowMessage("User Exist");
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

        public void GetUser()
        {
            try
            {

                var members = _memberModel.GetMembers();

                _memberView.DisplayMembers(members);

            }
            catch (Exception e)
            {
                _memberView.ShowMessage($"Error fetching members: {e.Message}");
            }
        }

        public void UpdateMember()
        {
            try
            {
                string name = _memberView.Name;
                string email = _memberView.Email.ToLower();
                string phoneNumber = _memberView.PhoneNumber;
                var members = _memberModel.GetMemberByEmail(email);
                if (members != null) {
                    bool isUpdated = false;
                    if(name != members.Name)
                    {
                        members.Name = name;
                        isUpdated = true;
                    }

                    if (phoneNumber != members.PhoneNumber)
                    {
                        members.PhoneNumber = phoneNumber;
                        isUpdated = true;
                    }

                    if (isUpdated)
                    {
                        _memberModel.UpdateMember(members);
                        _memberView.ShowMessage("Member updated successfully");
                    }
                    else
                    {
                        _memberView.ShowMessage("No changes detected.");
                    }
                }
                else
                {
                    _memberView.ShowMessage("Cannot change email address");
                }

            }
            catch (Exception e) { 
            _memberView.ShowMessage($"{e.Message}");
            }
        }

        public void DeleteMember()
        {
            try
            {
                string email = _memberView.Email.ToLower();
                if (email == null || email=="Email") {
                    _memberView.ShowMessage("Select a memeber first");
                }
                var members = _memberModel.GetMemberByEmail(email);
                if (members != null)
                {
                    bool isSucces = _memberModel.DeleteMember(email);
                    if (isSucces)
                    {
                        _memberView.ShowMessage("Member deleted successfully");
                    }
                    else
                    {
                        _memberView.ShowMessage("Cannot delete member until borrowed books are returned");
                    }
                }
            }
            catch (Exception e)
            {
                _memberView.ShowMessage($"{e.Message}");
            }
        }

        public void GetMostActiveMembers()
        {
            try
            {

                var activeMembers = _memberModel.GetMostActiveMembers();

                _activeMembers.DisplayMembers(activeMembers);

            }
            catch (Exception e)
            {
                _activeMembers.ShowMessage($"Error fetching members: {e.Message}");
            }
        }

    }
}
