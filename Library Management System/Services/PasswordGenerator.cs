using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Services
{
    internal class PasswordGenerator
    {
        public static Random Random = new Random();

        public static string GenerateNewPassword(int length = 8)
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_-+=<>?";
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[Random.Next(validChars.Length)]);

            }

            return password.ToString();
        }
    }
}
