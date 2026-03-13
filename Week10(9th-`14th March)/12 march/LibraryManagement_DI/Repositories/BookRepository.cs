using LibraryManagement_DI.Models;

namespace LibraryManagement_DI.Repositories
{
    public class BookRepository:IBookRepository
    {
        private List<Book> books = new List<Book>
        {
            new Book{ Id=1, Title="C# Programming", Author="John"},
            new Book{ Id=2, Title="ASP.NET Core", Author="David"},
            new Book{ Id=3, Title="Entity Framework", Author="James"}
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}
