using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;
using Library_Management_System.Services;
using Library_Management_System.View;
using Microsoft.VisualBasic.Logging;

namespace Library_Management_System.Controller
{
    internal class AdminLoginController
    {
        private readonly IAdminLogin adminLogin;
        private readonly AdminModel adminModel;
        private Admin admin;
        private AdminDashboard currentDashboardModel;
        private Dashboard currentDashboard;
        public AdminLoginController(IAdminLogin adminLogin) {
            this.adminLogin = adminLogin;
            this.adminModel = new AdminModel();
        }

        public AdminLoginController(AdminDashboard adminDashboard)
        {
            this.currentDashboardModel = adminDashboard;
        }

        public AdminLoginController(Dashboard adminDashboard)
        {
            this.currentDashboard = adminDashboard;
        }

        public void AdminLogin()
        {
            try
            {
                string name = adminLogin.Name.ToLower();
                string password = adminLogin.Password;
                admin = adminModel.GetAdmin(name,password);
                if (admin != null) {
                    if (adminLogin is AdminLogin form)
                    {
                        form.Hide(); 
                    }
                    if (admin.Role == "Admin")
                    {
                        AdminDashboard adminDashboard  = new AdminDashboard();
                        adminDashboard.ShowDialog();
                    }else if(admin.Role == "Librarian")
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();

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

        public void Logout()
        {
            try
            {

                if (currentDashboardModel != null)
                {
                    currentDashboardModel.Close();
                }
                if(currentDashboard != null)
                {
                    currentDashboard.Close();
                }
                AdminLogin loginView = new AdminLogin();
                loginView.Show();
                
                loginView.ShowMessage("You have been logged out.");
            }
            catch (Exception e)
            {
            }
        }
    }
}
