using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibrarySystem:ILibrarySystem
    {
        private Dictionary<Book, int> books = new Dictionary<Book, int>();

        public void AddBook(IBook book, int quantity)
        {
            Book b = (Book)book;

            if (books.ContainsKey(b))
                books[b] += quantity;
            else
                books.Add(b, quantity);
        }

        public void RemoveBook(IBook book, int quantity)
        {
            Book b = (Book)book;

            if (books.ContainsKey(b))
            {
                books[b] -= quantity;

                if (books[b] <= 0)
                    books.Remove(b);
            }
        }

        public int CalculateTotal()
        {
            int total = 0;

            foreach (var item in books)
            {
                total += item.Key.Price * item.Value;
            }

            return total;
        }

        public List<(string, int)> CategoryTotalPrice()
        {
            var result = books
                .GroupBy(b => b.Key.Category)
                .Select(g => (
                    g.Key,
                    g.Sum(x => x.Key.Price * x.Value)
                )).ToList();

            return result;
        }

        public List<(string, int, int)> BooksInfo()
        {
            List<(string, int, int)> result = new List<(string, int, int)>();

            foreach (var item in books)
            {
                result.Add((item.Key.Title, item.Value, item.Key.Price));
            }

            return result;
        }

        public List<(string, string, int)> CategoryAndAuthorWithCount()
        {
            var result = books
                .GroupBy(b => new { b.Key.Category, b.Key.Author })
                .Select(g => (
                    g.Key.Category,
                    g.Key.Author,
                    g.Sum(x => x.Value)
                )).ToList();

            return result;
        }
    }
}
