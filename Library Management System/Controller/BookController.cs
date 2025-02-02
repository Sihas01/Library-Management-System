using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.Model;
using Library_Management_System.View;

namespace Library_Management_System.Controller
{
    internal class BookController
    {
        private readonly IBookView _bookView;
        private readonly BookModel _bookModel;
        private readonly BorrowBookForm _borrowBookForm;
        private readonly MostBooks _mostBooks;

        public BookController(IBookView bookView)
        {
            _bookView = bookView;
            _bookModel = new BookModel();
        }

        public BookController(MostBooks mostBooks)
        {
            _mostBooks = mostBooks;
            _bookModel = new BookModel();
        }

        public BookController(BorrowBookForm borrowBookForm)
        {
            _borrowBookForm = borrowBookForm;
            _bookModel = new BookModel();
        }

        public void AddBook(string title, string author, string genre, string isbn)
        {
            bool success = _bookModel.CreateBook(title, author, genre, isbn);
            if (success)
            {
                _bookView.ShowMessage("Book added successfully");
            }
            else
            {
                _bookView.ShowMessage("Already Exisit");
            }
        }

        //public void FindBook(string title)
        //{
        //    var books = _bookModel.GetBook(title);
        //    _bookView.DisplayBooks(books);
        //}

        //public void RemoveBook(int id)
        //{
        //    bool success = _bookModel.DeleteBook(id);
        //    if (success)
        //    {
        //        _bookView.ShowMessage("Book removed successfully.");
        //    }
        //    else
        //    {
        //        _bookView.ShowMessage("Failed to remove book.");
        //    }
        //}

        //public void UpdateBook(int id, string title, string author, string genre, string isbn, bool isAvailable)
        //{
        //    bool success = _bookModel.UpdateBook(id, title, author, genre, isbn, isAvailable);
        //    if (success)
        //    {
        //        _bookView.ShowMessage("Book updated successfully.");
        //    }
        //    else
        //    {
        //        _bookView.ShowMessage("Failed to update book.");
        //    }
        //}

        public void ViewBooks()
        {
            try
            {
                var books = _bookModel.GetBooks();
                _bookView.DisplayBooks(books);
            }
            catch (ApplicationException ex)
            {
            _bookView.ShowMessage($"{ex.Message}");
            }
            catch (Exception ex)
            {
                _bookView.ShowMessage("An unexpected error occurred: " + ex.Message);
            }

        }

        public void ViewBooksForBorrow()
        {
            try
            {
                var books = _bookModel.GetBooks();
                _borrowBookForm.DisplayBooks(books);
            }
            catch (ApplicationException ex)
            {
                _borrowBookForm.ShowMessage($"{ex.Message}");
            }
            catch (Exception ex)
            {
                _borrowBookForm.ShowMessage("An unexpected error occurred: " + ex.Message);
            }

        }


        public void UpdateBook()
        {
            try
            {
                string title = _bookView.Title;
                string author = _bookView.Author;
                string genre = _bookView.Genre;
                string isbn = _bookView.ISBN;
                var book = _bookModel.GetBookByISBN(isbn);
                if (book != null)
                {
                    bool isUpdated = false;
                    if (title != book.Title)
                    {
                        book.Title = title;
                        isUpdated = true;
                    }

                    if (author != book.Author)
                    {
                        book.Author = author;
                        isUpdated = true;
                    }
                    if (genre != book.Genre)
                    {
                        book.Genre = genre;
                        isUpdated = true;
                    }

                    if (isUpdated)
                    {
                        _bookModel.UpdateBook(book);
                        _bookView.ShowMessage("Book updated successfully");
                    }
                    else
                    {
                        _bookView.ShowMessage("No changes detected.");
                    }
                }
                else
                {
                    _bookView.ShowMessage("Cannot change ISBN");
                }

            }
            catch (Exception e)
            {
                _bookView.ShowMessage($"{e.Message}");
            }
        }

        public void DeleteBook()
        {
            try
            {
                string isbn = _bookView.ISBN;
                if (isbn == null || isbn == "ISBN")
                {
                    _bookView.ShowMessage("Select a book first");
                }
                var book = _bookModel.GetBookByISBN(isbn);
                if (book != null)
                {
                    _bookModel.DeleteBook(isbn);
                    _bookView.ShowMessage("Book deleted successfully");
                }
            }
            catch (Exception e)
            {
                _bookView.ShowMessage($"{e.Message}");
            }
        }

        public void GetMostBorrowedBooks()
        {
            try
            {

                var mostBorrowedBooks = _bookModel.GetMostBorrowedBooks();

                _mostBooks.DisplayMembers(mostBorrowedBooks);

            }
            catch (Exception e)
            {
                _mostBooks.ShowMessage($"Error fetching members: {e.Message}");
            }
        }
    }
}
