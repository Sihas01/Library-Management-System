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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System.View
{
    public partial class MemberView : Form, IMemberView
    {
        private MemberController _memberController;
        public MemberView()
        {
            InitializeComponent();
            _memberController = new MemberController(this);
        }

        public string Name
        {
            get { return name.Text; }
            set { name.Text = value; }
        }

        public string Email
        {
            get { return email.Text; }
            set { email.Text = value; }
        }

        public string PhoneNumber
        {
            get { return mobileNumber.Text; }
            set { mobileNumber.Text = value; }
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

        private void register_Click(object sender, EventArgs e)
        {
            _memberController.CreateUser();
        }
    }
}
