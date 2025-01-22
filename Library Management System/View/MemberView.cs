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
        public MemberView()
        {
            InitializeComponent();
            _memberController = new MemberController(this);
            this.Load += MemberView_Load;
            this.poisonDataGridView1.CellClick += poisonDataGridView1_CellClick;
        }

        public string Name
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

        public void DisplayMembers(List<Member> filteredMembers)
        {


            poisonDataGridView1.DataSource = null;
            poisonDataGridView1.DataSource = filteredMembers;
            foreach (DataGridViewColumn column in poisonDataGridView1.Columns)
            {
                if (column.HeaderText == "Password" || column.Name == "Password" ||
                    column.HeaderText == "GeneratedPassword" || column.Name == "GeneratedPassword" ||
                    column.HeaderText == "HasChangedPassword" || column.Name == "HasChangedPassword")
                {
                    column.Visible = false;
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void hopeButton3_Click(object sender, EventArgs e)
        {
            _memberController.CreateUser();
            _memberController.GetUser();
        }
    }
}
