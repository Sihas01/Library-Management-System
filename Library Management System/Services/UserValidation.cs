using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Library_Management_System.Services
{
    internal class UserValidation
    {
        public static void ValidateUser(string name, string email, string phoneNumber)
        {
            ValidateName(name);
            ValidateEmail(email);
            ValidatePhoneNumber(phoneNumber);
            
        }


        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name is required");
        }

        public static void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException("Email is required.");

            if (!IsValidEmail(email))
                throw new ArgumentException("Invalid email format.");
        }

        public static void ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number is required.");

            if (!IsValidPhoneNumber(phoneNumber))
                throw new ArgumentException("Invalid phone number format.");
        }

        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password is required.");

            if (password.Length < 8)
                throw new ArgumentException("Password must be at least 8 characters long.");

            if (!Regex.IsMatch(password, @"[A-Z]"))
                throw new ArgumentException("Password must contain at least one uppercase letter.");

            if (!Regex.IsMatch(password, @"[a-z]"))
                throw new ArgumentException("Password must contain at least one lowercase letter.");

            if (!Regex.IsMatch(password, @"[0-9]"))
                throw new ArgumentException("Password must contain at least one number.");
        }

        private static bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }

    }
}
