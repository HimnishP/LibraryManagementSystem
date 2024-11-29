using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        private static int incrementId = -1;

        public User(string name, string email)
        {
            UserId = ++incrementId;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>(); // Correct initialization
        }

        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
            }
            else
            {
                Console.WriteLine("The book is not in the borrowed list.");
            }
        }
    }
}
