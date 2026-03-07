namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILibrarySystem librarySystem = new LibrarySystem();

            int bookCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < bookCount; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                Book b = new Book();
                b.Id = Convert.ToInt32(data[0]);
                b.Title = data[1];
                b.Author = data[2];
                b.Category = data[3];
                b.Price = Convert.ToInt32(data[4]);

                int quantity = Convert.ToInt32(data[5]);

                librarySystem.AddBook(b, quantity);
            }

            Console.WriteLine("Book Info:");
            var booksInfo = librarySystem.BooksInfo();

            foreach (var (title, quantity, price) in booksInfo.OrderBy(x => x.Item1))
            {
                Console.WriteLine($"Book Name: {title}, Quantity:{quantity}, Price:{price}");
            }

            Console.WriteLine("Category Total Price:");
            var categoryTotal = librarySystem.CategoryTotalPrice();

            foreach (var (category, price) in categoryTotal.OrderBy(x => x.Item1))
            {
                Console.WriteLine($"Category:{category}, Total Price:{price}");
            }

            Console.WriteLine("Category And Author With Count:");
            var categoryAuthor = librarySystem.CategoryAndAuthorWithCount();

            foreach (var (category, author, count) in categoryAuthor.OrderBy(x => x.Item1))
            {
                Console.WriteLine($"Category:{category}, Author:{author}, Count:{count}");
            }

            int total = librarySystem.CalculateTotal();
            Console.WriteLine($"Total Price: {total}");
        }
    }
}
