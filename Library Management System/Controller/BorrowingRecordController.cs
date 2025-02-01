using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;
using Library_Management_System.Services;
using Library_Management_System.View;

namespace Library_Management_System.Controller
{
    internal class BorrowingRecordController
    {
        private BorrowingRecodModel _borrowingRecodModel;
        private BorrowBookForm _borrowBookForm;

        public BorrowingRecordController(BorrowBookForm borrowBookForm)
        {
            _borrowingRecodModel = new BorrowingRecodModel();
            _borrowBookForm = borrowBookForm;
        }
        public void BorrowBook(string isbn)
        {
            try
            {
                Member member1 = LoggedInUser.Instance.CurrentUser;
                int memberid = member1.Id;
                string isSuccess = _borrowingRecodModel.BorrowBook(isbn, memberid);
                if (isSuccess == "success")
                {
                    _borrowBookForm.ShowMessage("Borrowed Successfully");
                }
                else if(isSuccess == "exsist")
                {
                    _borrowBookForm.ShowMessage("The book is not available for borrowing.");
                }
                else
                {
                    _borrowBookForm.ShowMessage("System error");
                }
            }
            catch (Exception ex)
            {
                _borrowBookForm.ShowMessage($"{ex.Message}");
            }


        }

      
    }
}
