using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryInventory
    {
        protected List<Book> Books { get; set; }

        public LibraryInventory(List<Book> books)
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
            }
        }

        // Search book method

    }
}
