using System.Xml.Linq;
using Library_Management_System.Controller;
using Library_Management_System.Model;
using Library_Management_System.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System
{
    public partial class Form1 : Form, ILogin
    {
        private AccountController accountController;
        public Form1()
        {
            InitializeComponent();
            accountController = new AccountController(this);
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
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

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            accountController.Login();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();

           
        }
    }
}
