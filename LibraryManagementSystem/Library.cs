using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        public List<Book> Catalog { get; private set; }
        public List<User> Users { get; private set; }

        public Library()
        {
            Catalog = new List<Book>();
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public Book FindBookByISBN(string isbn)
        {
            return Catalog.FirstOrDefault(b => b.ISBN == isbn);
        }

        public User FindUserById(int userId)
        {
            return Users.FirstOrDefault(u => u.UserId == userId);
        }

        public void GenerateReports()
        {
            Console.WriteLine("Library Inventory Report:");
            foreach (var book in Catalog)
            {
                Console.WriteLine($"{book.Title} by {book.Author} - Copies Available: {book.CopiesAvailable}");
            }
        }
    }
}
