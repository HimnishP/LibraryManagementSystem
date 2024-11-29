using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string YearPublished { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }

        public static int incrementId = -1;

        public Book(string title, string author, string genre, string yearPublished, string iSBN, int copiesAvailable)
        {
            BookId = ++incrementId;
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            ISBN = iSBN;
            CopiesAvailable = copiesAvailable;
        }
    }
}