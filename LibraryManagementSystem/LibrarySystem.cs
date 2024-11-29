using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibrarySystem
    {
        private static LibrarySystem instance;

        private LibrarySystem() { }

        public static LibrarySystem GetInstance()
        {
            if (instance == null)
            {
                instance = new LibrarySystem();
            }
            return instance;
        }
    }
}
