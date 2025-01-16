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
    public partial class Msg : Form
    {
        private AccountController accountController;
        public Msg()
        {
            InitializeComponent();
            accountController = new AccountController(this);
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
        private void button1_Click(object sender, EventArgs e)
        {
            accountController.Update();
            
        }
    }
}
