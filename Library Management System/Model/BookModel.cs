using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System.Model
{
    internal class BookModel
    {
        private readonly BookDAO _bookDao;


        public BookModel()
        {
            _bookDao = new BookDAO();
        }

        public bool CreateBook(string title, string author, string genre, string isbn)
        {
            var exsistingBook = _bookDao.GetBookByISBN(isbn);
            if (exsistingBook == null)
            {
                var book = new Book(title, author, genre, isbn);
                return _bookDao.CreateBook(book);
            }
            else
            {
                return false;
            }
        }

        public List<Book> GetBooks()
        {
            return _bookDao.GetBooks();
        }

        public Book GetBookByISBN(string isbn) {
            return _bookDao.GetBookByISBN(isbn);
        }

        public void UpdateBook(Book book) {
        _bookDao.UpdateBook(book);
        }

        public void DeleteBook(string isbn)
        {
            _bookDao.DeleteBook(isbn);
        }

        public void UpdateBookAsBorrowed(Book book)
        {
            _bookDao.UpdateAsBorrowed(book);
        }
    }
}
