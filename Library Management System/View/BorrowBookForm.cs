using Library_Management_System.Controller;
using Library_Management_System.Model;
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
    public partial class BorrowBookForm : Form
    {
        private BookController _bookController;
        private BorrowingRecordController _borrowController;
        private BindingSource _bindingSource;

        private string selectedISBN;
        public BorrowBookForm()
        {
            InitializeComponent();
            _bookController = new BookController(this);
            this.Load += BorrowBook_Load;
            this.bookList.CellClick += bookList_CellClick;
            _bindingSource = new BindingSource();
            _borrowController = new BorrowingRecordController(this);
            this.Activated += BorrowBook_Activated;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }


        public DataTable ConvertToDataTable(List<Book> books)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            dt.Columns.Add("Genre", typeof(string));
            dt.Columns.Add("ISBN", typeof(string));

            foreach (var book in books)
            {
                dt.Rows.Add(book.Title, book.Author, book.Genre, book.ISBN);
            }

            return dt;
        }

        public void DisplayBooks(List<Book> books)
        {
            DataTable dt = ConvertToDataTable(books);
            _bindingSource.DataSource = dt;
            bookList.DataSource = _bindingSource;

        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {

            _bookController.ViewBooksForBorrow();
        }

        private void bookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = bookList.Rows[e.RowIndex];
                selectedISBN = row.Cells["ISBN"].Value.ToString();

            }
        }

     

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            string filterExpression = string.Format("Title LIKE '%{0}%'", searchQuery);
            _bindingSource.Filter = filterExpression;
        }

        private void hopeButton3_Click(object sender, EventArgs e)
        {
            _borrowController.BorrowBook(selectedISBN);
        }

        private void BorrowBook_Activated(object sender, EventArgs e)
        {
            _bookController.ViewBooksForBorrow(); 
        }
    }
}
