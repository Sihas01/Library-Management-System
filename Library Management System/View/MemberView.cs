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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System.View
{
    public partial class MemberView : Form, IMemberView
    {
        private MemberController _memberController;
        private BindingSource _bindingSource;
        public MemberView()
        {
            InitializeComponent();
            _memberController = new MemberController(this);
            this.Load += MemberView_Load;
            this.poisonDataGridView1.CellClick += poisonDataGridView1_CellClick;
            _bindingSource = new BindingSource();
            nameTextBox.Text = "Name";
        }

        public new string Name
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
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


        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void MemberView_Load(object sender, EventArgs e)
        {

            _memberController.GetUser();


        }

        public DataTable ConvertToDataTable(List<Member> members)
        {
            DataTable dt = new DataTable();

            // Add columns to the DataTable (based on Member properties)
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("FinesDeu",typeof(double));

            // Add rows from the Member list
            foreach (var member in members)
            {
                dt.Rows.Add(member.Name, member.Email, member.PhoneNumber,member.FinesDeu);
            }

            return dt;
        }

        public void DisplayMembers(List<Member> members)
        {
            DataTable dt = ConvertToDataTable(members);
            _bindingSource.DataSource = dt;
            poisonDataGridView1.DataSource = _bindingSource;
        }

        private void poisonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = poisonDataGridView1.Rows[e.RowIndex];

                nameTextBox.Text = row.Cells["Name"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
                mobileNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
            }
        }
        private void hopeButton3_Click(object sender, EventArgs e)
        {
            _memberController.CreateUser();
            _memberController.GetUser();
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            _memberController.UpdateMember();
            _memberController.GetUser();
        }

        private void hopeButton2_Click(object sender, EventArgs e)
        {
            _memberController.DeleteMember();
            _memberController.GetUser();
        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            string filterExpression = string.Format("Name LIKE '%{0}%'",searchQuery);
            _bindingSource.Filter = filterExpression;
        }
    }
}
