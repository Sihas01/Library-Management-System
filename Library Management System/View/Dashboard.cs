using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.View
{
    public partial class Dashboard : Form
    {
        DashboardView dashboardview;
        ViewMember viewMember;
        MemberView memberView;
        public Dashboard()
        {
            InitializeComponent();
            viewMember = null;
            dashboardview = null;
            memberView = null;
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
            if (viewMember == null || viewMember.IsDisposed)
            {
                viewMember = new ViewMember();
                viewMember.FormClosed += ViewMember_FormClosed;
                viewMember.MdiParent = this;
                viewMember.Dock = DockStyle.Fill;
                viewMember.Show();
            }
            else
            {
                viewMember.Activate();
            }



        }

        private void ViewMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewMember.Dispose();
            viewMember = null;
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
    }
}