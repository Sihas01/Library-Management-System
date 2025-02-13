﻿using System;
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
        private ReturnBookForm _returnBookForm;

        public BorrowingRecordController(BorrowBookForm borrowBookForm)
        {
            _borrowingRecodModel = new BorrowingRecodModel();
            _borrowBookForm = borrowBookForm;
        }
        public BorrowingRecordController()
        {
            _borrowingRecodModel = new BorrowingRecodModel();
        }
        public BorrowingRecordController(ReturnBookForm returnBookForm)
        {
            _borrowingRecodModel = new BorrowingRecodModel();
            _returnBookForm = returnBookForm;
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
                else if (isSuccess == "not_available")
                {
                    _borrowBookForm.ShowMessage("The book is not available for borrowing.");
                }
                else
                {
                    _borrowBookForm.ShowMessage("System error occurred. Please try again later.");
                }
            }
            catch (Exception ex)
            {
                _borrowBookForm.ShowMessage($"{ex.Message}");
            }


        }
        public void Getborrowrecords()
        {
            Member member1 = LoggedInUser.Instance.CurrentUser;
            int memberid = member1.Id;
            try
            {
                var result = _borrowingRecodModel.Getborrowedbooks(memberid);
                if (result != null || result.Count > 0)
                {
                    _returnBookForm.DisplayRecods(result);
                }
                else
                {
                    _returnBookForm.ShowMessage("error");
                }
            }
            catch (Exception ex)
            {
                _returnBookForm.ShowMessage($"{ex.Message}");
            }


        }


        public void ReturnBook(int recordId)
        {
            if (recordId == 0)
            {
                _returnBookForm.ShowMessage("Select option first");
            }
            else
            {
                try
                {
                    bool isSuccess = _borrowingRecodModel.ReturnBook(recordId);
                    if (isSuccess)
                    {

                        _returnBookForm.ShowMessage("Returned Book successfully");
                        Getborrowrecords();
                    }
                    else
                    {
                        _returnBookForm.ShowMessage("System Failer, try again later");
                    }
                }
                catch (Exception ex)
                {
                    _returnBookForm.ShowMessage($"{ex.Message}");
                }
            }
        }

    }
}