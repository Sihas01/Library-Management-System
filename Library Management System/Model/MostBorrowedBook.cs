using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    public class MostBorrowedBook
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int BorrowCount { get; set; }
    }
}
