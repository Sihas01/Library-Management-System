using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    public class Fine
    {
        public int Fine_Id { get; set; }
        public int MemberId { get; set; }
        public decimal Amount { get; private set; }
        public string Status { get; set; }

        public Fine(int memberId, decimal amount, string status)
        {
            MemberId = memberId;
            Amount = amount;
            Status = status;
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }
    }
}
