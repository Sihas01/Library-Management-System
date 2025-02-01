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
    internal class FineController
    {
        private FineModel _model;
        private FineForm _form;
        public FineController(FineForm fineForm) {
        
            _model = new FineModel();
            _form = fineForm;
        
        }

        public void GetFines()
        {

            try
            {
                Member member1 = LoggedInUser.Instance.CurrentUser;
                if (member1 == null)
                {
                    _form.ShowMessage("User not logged in. Please log in first.");
                    return;
                }
                int memberId = member1.Id;
                var fines = _model.GetFines(memberId);
                if (fines == null)
                {
                    _form.ShowMessage("No fines found.");
                }
                else
                {
                    _form.DisplayFines(fines);
                }
            }
            catch (Exception ex)
            {
                _form.ShowMessage("An error occurred while retrieving the fines. Please try again later.");
            }
        }

        public void UpdateFineStatus(int fineId)
        {
            try
            {
                if ( fineId == 0) {
                    _form.ShowMessage("Please select a valid fine option.");
                }
                else
                {
                    bool isSuccess = _model.UpdateFineStatus(fineId);
                    if (isSuccess)
                    {
                        _form.ShowMessage("Fine paid successfully.");
                        GetFines();
                    }
                    else
                    {
                        _form.ShowMessage("Payment failed. Please try again.");
                    }
                }
                
            }
            catch (Exception ex)
            {
                _form.ShowMessage("An error occurred while updating the fine status. Please try again later.");
            }
        }
    }
}
