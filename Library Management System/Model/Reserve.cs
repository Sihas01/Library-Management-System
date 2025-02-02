using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    public class Reserve
    {
        public int ReservationId { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Status { get; set; }
        public int Member_id { get; set; }
        public int Book_id {  get; set; }

        public Reserve(int memberId,int bookId,DateTime dueDate)
        {
            this.ReservationDate = dueDate;
            this.Status = "pending";
            this.Member_id = memberId;
            this.Book_id = bookId;
        }
    }
}
