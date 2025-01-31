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
    public partial class MemberDashboard : Form
    {
        BorrowBookForm borrowBookForm;
        ReturnBookForm returnBookForm;
        ReserveBookForm reserveBookForm;
        FineForm fineForm;
        MemeberDashboardView memeberDashboardView;
        public MemberDashboard()
        {
            InitializeComponent();
            borrowBookForm = null;
            returnBookForm = null;
            reserveBookForm = null;
            fineForm = null;
            memeberDashboardView = null;
            this.Load += MemberDashboard_Load;

        }
        private void OpenDashboard()
        {
    
            if (memeberDashboardView == null || memeberDashboardView.IsDisposed)
            {
                memeberDashboardView = new MemeberDashboardView();
                memeberDashboardView.FormClosed += memberDashboard_Closed;
                memeberDashboardView.MdiParent = this;
                memeberDashboardView.Dock = DockStyle.Fill;
                memeberDashboardView.Show();
            }
            else
            {

                memeberDashboardView.Activate();
            }
        }

        private void memberDashboard_Closed(object sender, FormClosedEventArgs e)
        {
            memeberDashboardView.Dispose();
            memeberDashboardView = null;
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            OpenDashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenDashboard();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (borrowBookForm == null || borrowBookForm.IsDisposed)
            {
                borrowBookForm = new BorrowBookForm();
                borrowBookForm.FormClosed += borrowBookForm_Closed;
                borrowBookForm.MdiParent = this;
                borrowBookForm.Dock = DockStyle.Fill;
                borrowBookForm.Show();
            }
            else
            {
                borrowBookForm.Activate();
            }
        }

        private void borrowBookForm_Closed(object sender, FormClosedEventArgs e)
        {
            borrowBookForm.Dispose();
            borrowBookForm = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (returnBookForm == null || returnBookForm.IsDisposed)
            {
                returnBookForm = new ReturnBookForm();
                returnBookForm.FormClosed += returnBookForm_Closed;
                returnBookForm.MdiParent = this;
                returnBookForm.Dock = DockStyle.Fill;
                returnBookForm.Show();
            }
            else
            {
                returnBookForm.Activate();
            }
        }

        private void returnBookForm_Closed(object sender, FormClosedEventArgs e)
        {
            returnBookForm.Dispose();
            returnBookForm = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (reserveBookForm == null || reserveBookForm.IsDisposed)
            {
                reserveBookForm = new ReserveBookForm();
                reserveBookForm.FormClosed += reserveBookForm_Closed;
                reserveBookForm.MdiParent = this;
                reserveBookForm.Dock = DockStyle.Fill;
                reserveBookForm.Show();
            }
            else
            {
                reserveBookForm.Activate();
            }
        }

        private void reserveBookForm_Closed(object sender, FormClosedEventArgs e)
        {
            reserveBookForm.Dispose();
            reserveBookForm = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fineForm == null || fineForm.IsDisposed)
            {
                fineForm = new FineForm();
                fineForm.FormClosed += FineForm_Closed;
                fineForm.MdiParent = this;
                fineForm.Dock = DockStyle.Fill;
                fineForm.Show();
            }
            else
            {
                fineForm.Activate();
            }
        }

        private void FineForm_Closed(object sender, FormClosedEventArgs e)
        {
            fineForm.Dispose();
            fineForm = null;
        }
    }
}
