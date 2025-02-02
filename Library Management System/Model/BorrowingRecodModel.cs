using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.DAO;
using Microsoft.VisualBasic;

namespace Library_Management_System.Model
{
    internal class BorrowingRecodModel
    {
        private BorrowingRecodDAO _borrowingRecodDAO;
        private BookModel _bookModel;
        private BorrowingRecord _borrowingRecord;
        private FineModel _fineModel;

        public BorrowingRecodModel()
        {
            _borrowingRecodDAO = new BorrowingRecodDAO();
            _bookModel = new BookModel();
            _fineModel = new FineModel();
        }

        public string BorrowBook(string bookISBN, int memberId)
        {
            Book book = _bookModel.GetBookByISBN(bookISBN);
            if (book == null || !book.CheckAvailability())
            {
                return "not_available";
            }

            BorrowingRecord borrowingRecord = new BorrowingRecord(book.Id, memberId);
            bool isSuccess = _borrowingRecodDAO.BorrowBook(borrowingRecord);
            if (isSuccess)
            {
                book.MarkAsBorrowed();
                _bookModel.UpdateBookAsBorrowed(book);
                return "success";
            }
            return "error";
        }
        public List<BorrowingRecord> Getborrowedbooks(int memberid)
        {
            return _borrowingRecodDAO.Getborrowedbooks(memberid);
        }

        public BorrowingRecord GetborrowRecord(int bookid)
        {
            return _borrowingRecodDAO.GetborrowRecord(bookid);
        }

        public bool ReturnBook(int recordId)
        {

            var borrowingRecord = _borrowingRecodDAO.GetBorrowedRecords(recordId);
            if (borrowingRecord != null)
            {
                borrowingRecord.Return_Date = DateTime.Now;
                bool hasFine = borrowingRecord.CalculateFine();
                if (hasFine)
                {
                    _fineModel.AddFine(borrowingRecord.Fine);
                }

                Book book = _bookModel.GetBookByID(borrowingRecord.BookId);
                if (book != null)
                {
                    bool done = book.MarkAsReturned();
                    if (done)
                    {
                        _bookModel.UpdateBookAsBorrowed(book);
                        _borrowingRecodDAO.ReturnBook(borrowingRecord);
                        return true;
                    }

                }

            }
            return false;
        }
    }
}