using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int CopiesAvailable { get; set; }

        public Book(string isbn, string title, string author, string publisher, int copiesAvailable)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Publisher = publisher;
            CopiesAvailable = copiesAvailable;
        }

        public void AddCopies(int count)
        {
            CopiesAvailable += count;
        }

        public bool BorrowBook()
        {
            if (CopiesAvailable > 0)
            {
                CopiesAvailable--;
                return true;
            }
            return false;
        }

        public void ReturnBook()
        {
            CopiesAvailable++;
        }
    }
}
