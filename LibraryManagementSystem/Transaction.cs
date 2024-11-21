using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Transaction
    {
        public int TransactionId { get; private set; }
        public User Borrower { get; private set; }
        public Book BorrowedBook { get; private set; }
        public DateTime BorrowDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }

        public Transaction(int transactionId, User borrower, Book borrowedBook)
        {
            TransactionId = transactionId;
            Borrower = borrower;
            BorrowedBook = borrowedBook;
            BorrowDate = DateTime.Now;
        }

        public void CompleteReturn()
        {
            ReturnDate = DateTime.Now;
        }
    }
}
