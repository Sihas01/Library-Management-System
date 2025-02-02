using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.db;
using Library_Management_System.Model;
using Mysqlx.Crud;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System.DAO
{
    internal class BookDAO
    {
        private Database _database;

        public BookDAO()
        {
            _database = new Database();
        }

        public bool CreateBook(Book book)
        {
            try
            {
                var columns = new List<string> { "title", "author", "genre", "isbn", "isAvailable" };
                var values = new List<object>
                {
                    book.Title,
                    book.Author,
                    book.Genre,
                    book.ISBN,
                    book.IsAvailable ? 1 : 0
                };

                _database.Insert("book", columns, values);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Book GetBookByISBN(string ISBN)
        {
            try
            {
                var books = _database.Select("book", "*", $"isbn = '{ISBN}'");
                if (books != null && books.Count > 0)
                {
                    var bookData = books[0];
                    var book = new Book
                    {
                        Title = bookData["title"],
                        Author = bookData["author"],
                        ISBN = bookData["isbn"],
                        Genre = bookData["genre"],
                        IsAvailable = bookData["isAvailable"] == "1"
                    };
                    book.Id = Convert.ToInt32(bookData["id"]);
                    return book;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving member by email.", ex);
            }
        }

        public Book GetBookByID(int bookid)
        {
            try
            {
                var books = _database.Select("book", "*", $"id = '{bookid}'");
                if (books != null && books.Count > 0)
                {
                    var bookData = books[0];
                    var book = new Book
                    {
                        Title = bookData["title"],
                        Author = bookData["author"],
                        ISBN = bookData["isbn"],
                        Genre = bookData["genre"],
                        IsAvailable = bookData["isAvailable"] == "1"
                    };
                    book.Id = Convert.ToInt32(bookData["id"]);
                    return book;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving member by email.", ex);
            }
        }

        public List<Book> GetBooks()
        {
            try
            {
                var books = new List<Book>();
                var result = _database.Select("book");

                foreach (var row in result)
                {
                    var book = new Book(row["title"], row["author"], row["genre"], row["isbn"])
                    {
                        IsAvailable = row["isAvailable"] == "1",
                        Id = Convert.ToInt32(row["id"])
                    };
                    books.Add(book);
                }

                return books;
            }
            catch (KeyNotFoundException knfEx)
            {
                throw new ApplicationException("Missing expected column in row", knfEx);
            }
            catch (InvalidCastException castEx)
            {
                throw new ApplicationException("Invalid data format in row", castEx);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error processing book row", ex);
            }
        }

        public bool UpdateBook(Book book)
        {
            try
            {
                List<string> setClauses = new List<string>
                {
                    $"title = '{book.Title}'",
                    $"author = '{book.Author}'",
                    $"genre = '{book.Genre}'",

                };
                string condition = $"isbn = '{book.ISBN}'";
                _database.Update("book", setClauses, condition);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void DeleteBook(string isbn)
        {
            string condition = $"isbn = '{isbn}'";
            _database.Delete("book", condition);
        }


        public bool UpdateAsBorrowed(Book book)
        {
            try
            {
                List<string> setClauses = new List<string>
                {
                    $"IsAvailable = {book.IsAvailable}",
                };
                string condition = $"isbn = '{book.ISBN}'";
                _database.Update("book", setClauses, condition);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<MostBorrowedBook> GetMostBorrowedBooks(int limit = 10)
        {
            try
            {
                var mostBorrowedBooks = new List<MostBorrowedBook>();

                string query = $"SELECT b.id, b.title, COUNT(*) AS borrow_count " +
                               $"FROM borrowingrecord br " +
                $"INNER JOIN book b ON br.Book_id = b.id " +
                               $"GROUP BY b.id, b.title " +
                               $"ORDER BY borrow_count DESC " +
                               $"LIMIT {limit};";

                var result = _database.Select1(query);

                if (result == null || result.Count == 0)
                {
                    return mostBorrowedBooks;
                }

                foreach (var row in result)
                {
                    try
                    {
                        var mostBorrowedBook = new MostBorrowedBook
                        {
                            BookId = Convert.ToInt32(row["id"]),
                            BookTitle = row["title"],
                            BorrowCount = Convert.ToInt32(row["borrow_count"]),
                        };
                        mostBorrowedBooks.Add(mostBorrowedBook);
                    }
                    catch (Exception innerEx)
                    {
                        Console.WriteLine($"Error processing row: {innerEx.Message}");
                    }
                }

                return mostBorrowedBooks;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                throw new ApplicationException("Error retrieving most borrowed books.", ex);
            }
        }
    }
}