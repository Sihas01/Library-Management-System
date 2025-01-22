using System.Xml.Linq;
using Library_Management_System.Controller;
using Library_Management_System.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System
{
    public partial class Form1 : Form,ILogin
    {
        private AccountController accountController;
        public Form1()
        {
            InitializeComponent();
            accountController =  new AccountController(this);
         
        }

        public string Name
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
     
    }
}
