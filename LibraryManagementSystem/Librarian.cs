using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Librarian : User
    {
        public Librarian(int userId, string name, string email) : base(userId, name, email) { }

        public void AddBook(Book book, List<Book> libraryCatalog)
        {
            libraryCatalog.Add(book);
        }

        public void RemoveBook(Book book, List<Book> libraryCatalog)
        {
            libraryCatalog.Remove(book);
        }
    }
}
