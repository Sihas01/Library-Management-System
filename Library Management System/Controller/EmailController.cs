using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Services;

namespace Library_Management_System.Controller
{
    internal class EmailController
    {
        private MailService mailService;

        public EmailController()
        {
            mailService = new MailService("smtp.gmail.com", 587, "nikanhaduwe1375@gmail.com", "", "nikanhaduwe1375@gmail.com");
        }

        public string SendEmail(string toEmail, string subject, string body)
        {
            string message = mailService.SendEmail(toEmail, subject, body);
            return message;
        }
    }
}
