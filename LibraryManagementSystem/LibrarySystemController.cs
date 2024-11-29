using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    internal class LibrarySystemController
    {
        private readonly LibrarySystem librarySystem;

        public LibrarySystemController()
        {
            librarySystem = LibrarySystem.GetInstance();
        }

        // Add a Book
        public void AddBook(string title, string author, string genre, string yearPublished, string isbn, int copies)
        {
            try
            {
                var book = new Book(title, author, genre, yearPublished, isbn, copies);
                librarySystem.AddBook(book);
                Console.WriteLine($"Book '{title}' added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding book: {ex.Message}");
            }
        }

        // Remove a Book
        public void RemoveBook(int bookId)
        {
            if (librarySystem.RemoveBook(bookId))
                Console.WriteLine($"Book with ID {bookId} removed successfully.");
            else
                Console.WriteLine($"Book with ID {bookId} not found.");
        }

        // Add a User
        public void AddUser(string name, string email, string userType)
        {
            try
            {
                User user;
                switch (userType.ToLower())
                {
                    case "librarian":
                        user = new Librarian(name, email);
                        break;
                    case "customer":
                        user = new Customer(name, email);
                        break;
                    default:
                        throw new ArgumentException("Invalid user type. Must be 'librarian' or 'customer'.");
                }
                librarySystem.AddUser(user);
                Console.WriteLine($"User '{name}' added as {userType}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding user: {ex.Message}");
            }
        }

        // Remove a User
        public void RemoveUser(int userId)
        {
            if (librarySystem.RemoveUser(userId))
                Console.WriteLine($"User with ID {userId} removed successfully.");
            else
                Console.WriteLine($"User with ID {userId} not found.");
        }

        // Borrow a Book
        public void BorrowBook(int bookId, int userId)
        {
            try
            {
                librarySystem.BorrowBook(bookId, userId);
                Console.WriteLine($"Book with ID {bookId} borrowed by User ID {userId}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error borrowing book: {ex.Message}");
            }
        }

        // Return a Book
        public void ReturnBook(int bookId, int userId)
        {
            try
            {
                librarySystem.ReturnBook(bookId, userId);
                Console.WriteLine($"Book with ID {bookId} returned by User ID {userId}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error returning book: {ex.Message}");
            }
        }

        // Search Books
        public void SearchBooks(string searchType, string query)
        {
            List<Book> results;

            switch (searchType.ToLower())
            {
                case "title":
                    results = librarySystem.SearchBookByTitle(query);
                    break;
                case "author":
                    results = librarySystem.SearchBookByAuthor(query);
                    break;
                case "genre":
                    results = librarySystem.SearchBookByGenre(query);
                    break;
                default:
                    Console.WriteLine("Invalid search type. Must be 'title', 'author', or 'genre'.");
                    return;
            }

            if (results.Count > 0)
            {
                Console.WriteLine($"Books found ({results.Count}):");
                foreach (var book in results)
                {
                    Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}");
                }
            }
            else
            {
                Console.WriteLine("No books found.");
            }
        }

        // Search Users
        public void SearchUsers(string name)
        {
            var results = librarySystem.SearchUserByName(name);
            if (results.Count > 0)
            {
                Console.WriteLine($"Users found ({results.Count}):");
                foreach (var user in results)
                    Console.WriteLine($"ID: {user.UserId}, Name: {user.Name}, Email: {user.Email}");
            }
            else
            {
                Console.WriteLine("No users found.");
            }
        }

        // Generate Reports
        public void GenerateInventoryReport()
        {
            string report = librarySystem.GenerateInventoryReport();
            Console.WriteLine("Inventory Report:");
            Console.WriteLine(report);
        }

        public void GenerateUserReport()
        {
            string report = librarySystem.GenerateUserReport();
            Console.WriteLine("User Report:");
            Console.WriteLine(report);
        }

        // List All Books
        public void ListAllBooks()
        {
            var books = librarySystem.GetAllBooks();
            if (books.Count > 0)
            {
                Console.WriteLine("Books:");
                foreach (var book in books)
                    Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Copies: {book.CopiesAvailable}");
            }
            else
            {
                Console.WriteLine("No books available.");
            }
        }

        // List All Users
        public void ListAllUsers()
        {
            var users = librarySystem.GetAllUsers();
            if (users.Count > 0)
            {
                Console.WriteLine("Users:");
                foreach (var user in users)
                    Console.WriteLine($"ID: {user.UserId}, Name: {user.Name}, Email: {user.Email}");
            }
            else
            {
                Console.WriteLine("No users found.");
            }
        }
    }
}
