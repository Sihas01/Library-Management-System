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
    public partial class AdminLogin : Form, IAdminLogin
    {
        private AdminLoginController _controller;
        public AdminLogin()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            _controller = new AdminLoginController(this);
            name.Text = "Email Address";
        }
        public new string Name
        {
            get { return name.Text; }
            set { name.Text = value; }
        }

        public string Password
        {
            get { return password.Text; }
            set { password.Text = value; }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            _controller.AdminLogin();
        }
    }
}
