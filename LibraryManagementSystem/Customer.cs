using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Customer : User
    {
        public Customer(string name, string email) : base(name, email)
        {
        }
    }
}
