using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal interface ILibrarySystem
    {
        void AddBook(IBook book, int quantity);
        void RemoveBook(IBook book, int quantity);
        int CalculateTotal();
        List<(string, int)> CategoryTotalPrice();
        List<(string, int, int)> BooksInfo();
        List<(string, string, int)> CategoryAndAuthorWithCount();
    }
}
