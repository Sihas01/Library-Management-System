using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.DAO;

namespace Library_Management_System.Model
{
    internal class FineModel
    {
        private FineDAO _fineDAO;
        public FineModel()
        {
            _fineDAO = new FineDAO();
        }

        public bool AddFine(Fine fine)
        {
            if (fine != null)
            {
                return _fineDAO.AddFine(fine);
            }
            else
            {
                return false;
            }
        }
        public List<Fine> GetFines(int memberId)
        {
            return _fineDAO.GetDataFromDatabase(memberId);
        }

        public bool UpdateFineStatus(int findId)
        {
            return _fineDAO.UpdateFineStatus(findId);
        }
    }
}