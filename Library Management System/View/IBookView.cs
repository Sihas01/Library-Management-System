using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;

namespace Library_Management_System.View
{
    internal interface IBookView
    {
        string Title { get; set; }
        string Author { get; set; }
        string ISBN { get; set; }
        string Genre { get; set; }
        void ShowMessage(string message);
        void DisplayBooks(List<Book> books);
    }
}
