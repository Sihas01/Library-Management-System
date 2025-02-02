using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.db;
using Library_Management_System.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System.DAO
{
    internal class FineDAO
    {
        private Database _database;
        public FineDAO()
        {
            _database = new Database();
        }

        public List<Fine> GetDataFromDatabase(int memberId)
        {

            try
            {
                var fines = new List<Fine>();
                string condition = $"Member_id = '{memberId}' AND status = 'Unpaid'";
                var result = _database.Select("fine", "*", condition);

                foreach (var row in result)
                {

                    var fine = new Fine(Convert.ToInt32(row["Member_id"]), Convert.ToDecimal(row["amount"]), row["status"])
                    {
                        Fine_Id = Convert.ToInt32(row["fineID"])
                    };
                    fines.Add(fine);
                }
                return fines;
            }
            catch (KeyNotFoundException knfEx)
            {
                throw new ApplicationException("Missing expected column in row", knfEx);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving data", ex);
            }
        }


        public bool UpdateFineStatus(int fineId)
        {
            try
            {
                List<string> setClauses = new List<string>
                {
                    $"status = 'Paid'"
                };
                string condition = $"fineID = '{fineId}'";
                _database.Update("fine", setClauses, condition);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddFine(Fine fine)
        {
            try
            {
                var columns = new List<string> { "amount", "status", "Member_id" };
                var values = new List<object>
                {
                    fine.Amount,
                    fine.Status,
                    fine.MemberId
                };

                _database.Insert("fine", columns, values);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}