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
using ReaLTaiizor.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System.View
{
    public partial class ManageBooksView : Form, IBookView
    {
        private BookController _bookController;
        private BindingSource _bindingSource;
        public ManageBooksView()
        {
            InitializeComponent();
            _bookController = new BookController(this);
            this.Load += BookView_Load;
            this.bookGrid.CellClick += bookGrid_CellClick;
            _bindingSource = new BindingSource();
        }

        public new string Title
        {
            get { return title.Text; }
            set { title.Text = value; }
        }

        public string Author
        {
            get { return author.Text; }
            set { author.Text = value; }
        }

        public string ISBN
        {
            get { return isbn.Text; }
            set { isbn.Text = value; }
        }

        public string Genre
        {
            get { return genre.Text; }
            set { genre.Text = value; }
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
            bookGrid.DataSource = _bindingSource;

        }

        private void BookView_Load(object sender, EventArgs e)
        {

            _bookController.ViewBooks();


        }

        private void hopeButton3_Click(object sender, EventArgs e)
        {
            _bookController.AddBook(Title, Author, Genre, ISBN);
            _bookController.ViewBooks();

        }

        private void bookGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bookGrid.Rows[e.RowIndex];

                title.Text = row.Cells["Title"].Value.ToString();
                author.Text = row.Cells["Author"].Value.ToString();
                genre.Text = row.Cells["Genre"].Value.ToString();
                isbn.Text = row.Cells["ISBN"].Value.ToString();

            }
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            _bookController.UpdateBook();
            _bookController.ViewBooks();

        }

        private void hopeButton2_Click(object sender, EventArgs e)
        {
            _bookController.DeleteBook();
            _bookController.ViewBooks();
        }


        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            string filterExpression = string.Format("Title LIKE '%{0}%'", searchQuery);
            _bindingSource.Filter = filterExpression;
        }
    }
}
