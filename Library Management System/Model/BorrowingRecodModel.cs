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

        public BorrowingRecodModel()
        {
            _borrowingRecodDAO = new BorrowingRecodDAO();
            _bookModel = new BookModel();
        }

        public string BorrowBook(string bookISBN,int memberId)
        {
            Book book = _bookModel.GetBookByISBN(bookISBN);
            if (book == null || !book.CheckAvailability()) {
                return "exsist";
            }

            BorrowingRecord borrowingRecord = new BorrowingRecord(book.Id, memberId);
            bool isSuccess = _borrowingRecodDAO.BorrowBook(borrowingRecord);
            if (isSuccess) {
                book.MarkAsBorrowed();
                _bookModel.UpdateBookAsBorrowed(book);
                return "success";
            }
            return "Error";
        }
        public List<BorrowingRecord> Getborrowedbooks(int memberid) 
        {
            return _borrowingRecodDAO.Getborrowedbooks(memberid);
        }
    }
}
