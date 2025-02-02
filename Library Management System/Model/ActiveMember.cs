using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    public class ActiveMember
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int BorrowCount { get; set; }
    }
}
