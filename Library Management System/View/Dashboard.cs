using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.Controller;

namespace Library_Management_System.View
{
    public partial class Dashboard : Form
    {
        DashboardView dashboardview;
        MemberView memberView;
        ManageBooksView manageBooksView;
        public Dashboard()
        {
            InitializeComponent();
            dashboardview = null;
            memberView = null;
            manageBooksView = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboardview == null || dashboardview.IsDisposed)
            {
                dashboardview = new DashboardView();
                dashboardview.FormClosed += DashBoard_Closed;
                dashboardview.MdiParent = this;
                dashboardview.Dock = DockStyle.Fill;
                dashboardview.Show();
            }
            else
            {
                dashboardview.Activate();
            }
        }

        private void DashBoard_Closed(object sender, FormClosedEventArgs e)
        {
            dashboardview.Dispose();
            dashboardview = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (manageBooksView == null || manageBooksView.IsDisposed)
            {
                manageBooksView = new ManageBooksView();
                manageBooksView.FormClosed += ManageBook_Closed;
                manageBooksView.MdiParent = this;
                manageBooksView.Dock = DockStyle.Fill;
                manageBooksView.Show();
            }
            else
            {
                manageBooksView.Activate();
            }

        }

        private void ManageBook_Closed(object sender, FormClosedEventArgs e)
        {
            manageBooksView.Dispose();
            manageBooksView = null;
        }





        private void button3_Click(object sender, EventArgs e)
        {
            if (memberView == null || memberView.IsDisposed)
            {
                memberView = new MemberView();
                memberView.FormClosed += AddMember_Closed;
                memberView.MdiParent = this;
                memberView.Dock = DockStyle.Fill;
                memberView.Show();
            }
            else
            {
                memberView.Activate();
            }

        }

        private void AddMember_Closed(object sender, FormClosedEventArgs e)
        {
            memberView.Dispose();
            memberView = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminLoginController adminLogin = new AdminLoginController(this);
            adminLogin.Logout();
        }
    }
}