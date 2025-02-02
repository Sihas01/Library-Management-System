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
    public partial class ActiveMembers : Form
    {
        private MemberController _memberController;
        private BindingSource _bindingSource;


        public ActiveMembers()
        {
            InitializeComponent();
            _memberController = new MemberController(this);
            this.Load += ActiveMemberView_Load;
            _bindingSource = new BindingSource();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void ActiveMemberView_Load(object sender, EventArgs e)
        {

            _memberController.GetMostActiveMembers();


        }

        public DataTable ConvertToDataTable(List<ActiveMember> activeMembers)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MemberId", typeof(int));
            dt.Columns.Add("MemberName", typeof(string));
            dt.Columns.Add("Borrow Count", typeof(string));

            // Add rows from the Member list
            foreach (var member in activeMembers)
            {
                dt.Rows.Add(member.MemberId,member.MemberName,member.BorrowCount);
            }

            return dt;
        }

        public void DisplayMembers(List<ActiveMember> activeMembers)
        {
            DataTable dt = ConvertToDataTable(activeMembers);
            _bindingSource.DataSource = dt;
            poisonDataGridView1.DataSource = _bindingSource;
        }
    }
}
