using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using Mysqlx.Crud;
using Mysqlx.Cursor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;
using Microsoft.VisualBasic;

namespace Library_Management_System.Model
{
    public class BorrowingRecord
    {

        public int Record_id {get;set;}
        public DateTime Borrow_Date {get;set;}
        public DateTime Due_Date {get;set;}
        public DateTime? Return_Date { get;set;}
        public Fine Fine { get; set; } 
        public int BookId { get; set; }
        public int MemberId { get; set; }

        public BorrowingRecord(int bookId, int memberId)
        {
            Borrow_Date = DateTime.Now; 
            Due_Date = DateTime.Now.AddDays(7);
            BookId = bookId;
            MemberId = memberId;
            Return_Date = null ; 
            Fine = null; 
        }

        public void CalculateFine()
        {
            if (Return_Date.HasValue && Return_Date.Value > Due_Date)
            {
                int daysLate = (Return_Date.Value - Due_Date).Days;
                decimal fineAmount = daysLate * 100;
                Fine = new Fine(MemberId, fineAmount, "Unpaid");
            }
            else
            {
                Fine = null;
            }
            
        }
    }
}
