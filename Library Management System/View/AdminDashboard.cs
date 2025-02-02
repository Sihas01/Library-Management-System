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
    public partial class AdminDashboard : Form
    {
        private MostBooks _mostBooks;
        private ActiveMembers _activeMembers;
        public AdminDashboard()
        {
            InitializeComponent();
            _activeMembers = null;
            _mostBooks = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_mostBooks == null || _mostBooks.IsDisposed)
            {
                _mostBooks = new MostBooks();
                _mostBooks.FormClosed += bookVIew_Closed;
                _mostBooks.MdiParent = this;
                _mostBooks.Dock = DockStyle.Fill;
                _mostBooks.Show();
            }
            else
            {
                _mostBooks.Activate();
            }
        }

        private void bookVIew_Closed(object sender, FormClosedEventArgs e)
        {
            _mostBooks.Dispose();
            _mostBooks = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_activeMembers == null || _activeMembers.IsDisposed)
            {
                _activeMembers = new ActiveMembers();
                _activeMembers.FormClosed += activeMembers_Closed;
                _activeMembers.MdiParent = this;
                _activeMembers.Dock = DockStyle.Fill;
                _activeMembers.Show();
            }
            else
            {
                _activeMembers.Activate();
            }
        }

        private void activeMembers_Closed(object sender, FormClosedEventArgs e)
        {
            _activeMembers.Dispose();
            _activeMembers = null;
        }
    }
}
