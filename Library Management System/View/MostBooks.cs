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
    public partial class MostBooks : Form
    {

        private BookController bookController;
        private BindingSource _bindingSource;
        public MostBooks()
        {
            InitializeComponent();
            bookController = new BookController(this);
            this.Load += MostBorrowedBook_Load;
            _bindingSource = new BindingSource();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void MostBorrowedBook_Load(object sender, EventArgs e)
        {

            bookController.GetMostBorrowedBooks();


        }

        public DataTable ConvertToDataTable(List<MostBorrowedBook> mostBorrowedBooks)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("BookId", typeof(int));
            dt.Columns.Add("BookTitle", typeof(string));
            dt.Columns.Add("Borrow Count", typeof(string));

            // Add rows from the Member list
            foreach (var book in mostBorrowedBooks)
            {
                dt.Rows.Add(book.BookId, book.BookTitle, book.BorrowCount);
            }

            return dt;
        }

        public void DisplayMembers(List<MostBorrowedBook> mostBorrowedBooks)
        {
            DataTable dt = ConvertToDataTable(mostBorrowedBooks);
            _bindingSource.DataSource = dt;
            poisonDataGridView1.DataSource = _bindingSource;
        }
    }
}
