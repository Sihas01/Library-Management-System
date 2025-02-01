using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        public Book() { }
        public Book(string title,string author,string genre,string isbn)
        {
            Title = title;
            Author = author;
            Genre = genre;
            ISBN = isbn;
            IsAvailable = true;
        }

        public bool MarkAsBorrowed()
        {
            
            IsAvailable = false;
            return IsAvailable;
        }

        public bool MarkAsReturned()
        {
            
            IsAvailable = true;
            return IsAvailable;
        }

        public bool CheckAvailability()
        {
            
            return IsAvailable;
        }
    }
}
