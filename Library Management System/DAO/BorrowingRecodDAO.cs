using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.db;
using Library_Management_System.Model;

namespace Library_Management_System.DAO
{
    internal class BorrowingRecodDAO
    {
        private Database _database;
        public BorrowingRecodDAO() { 
        _database = new Database();
        }

        public bool BorrowBook(BorrowingRecord borrowingRecord)
        {
            try
            {
                var columns = new List<string> { "borrowDate", "dueDate", "returnDate", "fineAmount", "Book_id", "Member_id" };
                var values = new List<object>
                {
                    borrowingRecord.Borrow_Date.ToString("yyyy-MM-dd HH:mm:ss"),
                    borrowingRecord.Due_Date.ToString("yyyy-MM-dd HH:mm:ss"),
                    borrowingRecord.Return_Date.HasValue
        ? borrowingRecord.Return_Date.Value.ToString("yyyy-MM-dd HH:mm:ss")  
        : DBNull.Value,
                    borrowingRecord.Fine == null ? DBNull.Value : borrowingRecord.Fine,
                    borrowingRecord.BookId,
                    borrowingRecord.MemberId
                };

                _database.Insert("borrowingrecord", columns, values);
                return true;
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
                throw new ApplicationException("Error processing borrowing record row", ex);
            }
        }
    }
}
