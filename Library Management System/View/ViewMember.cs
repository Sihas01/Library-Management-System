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
using Library_Management_System.Model;

namespace Library_Management_System.View
{
    public partial class ViewMember : Form, IViewMember
    {
        private MemberController _memberController;
        public ViewMember()
        {
            InitializeComponent();
            _memberController = new MemberController(this);
            this.Load += MemberView_Load;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void DisplayMembers(List<Member> members)
        {
            dataGridViewMembers.DataSource = null; 
            dataGridViewMembers.DataSource = members; 

        }

        private void MemberView_Load(object sender, EventArgs e)
        {
            
             _memberController.GetUser();
            
            
        }


    }
}
