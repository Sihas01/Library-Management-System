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
    internal class ReserveController
    {
        private ReserveModel _reserveModel;
        private ReserveBookForm _reserveBookForm;
        private ReservationForm _reservationForm;
        public ReserveController(ReserveBookForm reserveBookForm) {
        _reserveModel = new ReserveModel();
            _reserveBookForm = reserveBookForm;
        }

        public ReserveController(ReservationForm reservationForm)
        {
            _reserveModel = new ReserveModel();
            _reservationForm = reservationForm;
        }

        public void AddReservation(string isbn)
        {
            try
            {
                Member member1 = LoggedInUser.Instance.CurrentUser;
                int memberid = member1.Id;

                string isSuccess = _reserveModel.ReserveBook(isbn, memberid);

                if (isSuccess == "success")
                {
                    _reserveBookForm.ShowMessage("Reservation was successful.");
                }
                else if (isSuccess == "available")
                {
                    _reserveBookForm.ShowMessage("The book is available for borrowing.");
                }
                else if (isSuccess == "notexist")
                {
                    _reserveBookForm.ShowMessage("The book does not exist in the system.");
                }
                else if (isSuccess == "reservefailed")
                {
                    _reserveBookForm.ShowMessage("Failed to reserve the book. Please try again.");
                }
                else if (isSuccess == "norecord")
                {
                    _reserveBookForm.ShowMessage("No borrowing record found for the book.");
                }
                else
                {
                    _reserveBookForm.ShowMessage("System error occurred. Please try again later.");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"An error occurred: {ex.Message}. Please try again later.";
                _reserveBookForm.ShowMessage(errorMessage);
            }

        }

        public void Getborrowrecords()
        {
            Member member1 = LoggedInUser.Instance.CurrentUser;
            int memberid = member1.Id;
            try
            {
                var result = _reserveModel.GetRecords(memberid);
                if (result != null || result.Count > 0)
                {
                    _reservationForm.DisplayRecords(result);
                }
                else
                {
                    _reservationForm.ShowMessage("error");
                }
            }
            catch (Exception ex)
            {
                _reservationForm.ShowMessage($"{ex.Message}");
            }


        }

        public void ConfirmReservation(int bookid,int recordid)
        {
            if (bookid == 0)
            {
                _reservationForm.ShowMessage("Please Select a option");
            }
            else
            {
                Member member1 = LoggedInUser.Instance.CurrentUser;
                int memberid = member1.Id;
                var result = _reserveModel.ConformReservation(bookid, memberid, recordid);
                if (result)
                {
                    _reservationForm.ShowMessage("Borrowed Successfully");
                    Getborrowrecords();
                }
                else
                {
                    _reservationForm.ShowMessage("try again later");
                }
            }
            
        }


    }
}
