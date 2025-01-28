using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;
using Library_Management_System.View;
using Microsoft.VisualBasic.Logging;

namespace Library_Management_System.Controller
{
    internal class AdminLoginController
    {
        private readonly IAdminLogin adminLogin;
        private readonly AdminModel adminModel;
        private Admin admin;
        public AdminLoginController(IAdminLogin adminLogin) {
            this.adminLogin = adminLogin;
            this.adminModel = new AdminModel();
        }

        public void AdminLogin()
        {
            try
            {
                string name = adminLogin.Name;
                string password = adminLogin.Password;
                admin = adminModel.GetAdmin(name,password);
                if (admin != null) {
                    adminLogin.ShowMessage("admin Found");
                    if(admin.Role == "Admin")
                    {
                        adminLogin.ShowMessage("admin ");
                    }else if(admin.Role == "Librarian")
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();

                    }
                }
                else
                {
                    adminLogin.ShowMessage("Invalid Credentials");
                }


            }
            catch (ArgumentException ex)
            {
                adminLogin.ShowMessage($"Error: {ex.Message}");
            }
        }
    }
}
