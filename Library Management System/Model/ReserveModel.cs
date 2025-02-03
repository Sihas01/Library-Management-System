using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.DAO;
using Library_Management_System.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System.Model
{
    internal class ReserveModel
    {
        private ReserveDAO _reserveDAO;

        public ReserveModel()
        {
            _reserveDAO = new ReserveDAO();
  
        }
        public string ReserveBook(string isbn, int memberid)
        {
            try
            {
                BookModel bookModel = new BookModel();
                Book book = bookModel.GetBookByISBN(isbn);

                if (book == null)
                {
                    return "notexist";
                }
                else
                {
                    bool isAvailable = book.IsAvailable;
                    if (isAvailable)
                    {
                        return "available"; 
                    }
                    else
                    {
                        BorrowingRecodModel borrowingRecodModel = new BorrowingRecodModel();
                        BorrowingRecord record = borrowingRecodModel.GetborrowRecord(book.Id);

                        if (record != null)
                        {
                            Reserve reserveResult = GetRecordsByBook(book.Id);
                            if (reserveResult == null)
                            {
                                Reserve reserve = new Reserve(memberid, book.Id, record.Due_Date);
                                bool isSuccess = _reserveDAO.ReserveBook(reserve);

                                if (isSuccess)
                                {
                                    return "success";
                                }
                                else
                                {
                                    return "reservefailed";
                                }
                            }
                            else
                            {
                                return "notre";
                            }
                        }
                        else
                        {
                            return "norecord"; 
                        }
                    }
                }
                return "no";
            }
            catch (Exception ex)
            {
                return $"error: {ex.Message}"; 
            }
        }

        public List<Reserve> GetRecords(int memberId)
        {
            return _reserveDAO.GetRecords(memberId);
        }

        public Reserve GetRecordsByBook(int bookId)
        {
            return _reserveDAO.GetRecordsById(bookId);
        }

        public bool ConformReservation(int bookid, int memeberid,int recordId)
        {
            BookModel bookModel = new BookModel();
            Book book = bookModel.GetBookByID(bookid);
            if(book == null)
            {
                return false;
            }
            BorrowingRecodModel borrowingRecodModel = new BorrowingRecodModel();
            string isSuccess = borrowingRecodModel.ConformBorrowBook(book.ISBN, memeberid);
            if (isSuccess == "success")
            {
                bool isPass = _reserveDAO.UpdateRecord(recordId);
                if (isPass) {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

    }
}
