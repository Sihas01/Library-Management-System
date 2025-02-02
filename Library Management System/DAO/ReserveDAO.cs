using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.db;
using Library_Management_System.Model;
using MySqlX.XDevAPI.Common;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System.DAO
{
    internal class ReserveDAO
    {
        private readonly Database _database;

        public ReserveDAO()
        {
            _database = new Database();
        }

        public bool ReserveBook(Reserve reserve)
        {
            try
            {
                var columns = new List<string> { "reservationDate", "status", "Member_id", "Book_id" };
                var values = new List<object>
                {
                    reserve.ReservationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    reserve.Status,
                    reserve.Member_id,
                    reserve.Book_id
                };

                _database.Insert("reservation", columns, values);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
          
        }

        public List<Reserve> GetRecords(int memberId)
        {
            try
            {
                var records = new List<Reserve>();
                var reserveRecords = _database.Select("reservation", "*", $"Member_id = '{memberId}' AND status = 'Pending'");
                foreach (var row in reserveRecords)
                {
                    var record = new Reserve(
                         Convert.ToInt32(row["Member_id"]),Convert.ToInt32(row["Book_id"]), DateTime.Parse(row["reservationDate"].ToString())
                        )
                    {
                       ReservationId = Convert.ToInt32(row["reservationID"])
                    };
                    records.Add(record);
                }

                return records;
                

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving member by email.", ex);
            }
        }


        public bool UpdateRecord(int recordId)
        {
            try
            {
                List<string> setClauses = new List<string>
                {
                    $"status = 'Completed'",
                };
                string condition = $"reservationID = '{recordId}'";
                _database.Update("reservation", setClauses, condition);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
