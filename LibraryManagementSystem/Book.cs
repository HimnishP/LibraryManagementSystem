using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string YearPublished { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }
        public bool AvailabilityStatus { get; private set; }

        public Book(int id, string title, string author, string genre, string yearPublished, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            ISBN = isbn;
            AvailabilityStatus = true; // Books are available by default
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

        //Methods
        public void MarkAsBorrowed()
        {
            if (!AvailabilityStatus)
            {
                Console.WriteLine($"The book '{Title}' is already borrowed.");
                return;
            }

            AvailabilityStatus = false;
            Console.WriteLine($"The book '{Title}' has been marked as borrowed.");
        }

        public void MarkAsReturned()
        {
            if (!AvailabilityStatus)
            {
                Console.WriteLine($"The book '{Title}' is already returned.");
                return;
            }

            AvailabilityStatus = true;
            Console.WriteLine($"The book '{Title}' has been marked as returned.");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Availability: {(AvailabilityStatus ? "Available" : "Borrowed")}");
        }
    }    
}