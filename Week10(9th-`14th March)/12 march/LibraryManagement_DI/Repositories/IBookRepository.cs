using LibraryManagement_DI.Models;

namespace LibraryManagement_DI.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
    }
}
