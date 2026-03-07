namespace Movie_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFilmLibrary library = new FilmLibrary();

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(',');

                Film film = new Film
                {
                    Title = input[0],
                    Director = input[1],
                    Year = Convert.ToInt32(input[2])
                };

                library.AddFilm(film);
            }

            Console.WriteLine("All Films:");
            foreach (var film in library.GetFilms())
            {
                Console.WriteLine($"{film.Title} - {film.Director} - {film.Year}");
            }

            string searchQuery = Console.ReadLine();
            Console.WriteLine("Search Results:");

            var results = library.SearchFilms(searchQuery);
            foreach (var film in results)
            {
                Console.WriteLine($"{film.Title} - {film.Director} - {film.Year}");
            }

            Console.WriteLine("Total Films: " + library.GetTotalFilmCount());

            string removeTitle = Console.ReadLine();
            library.RemoveFilm(removeTitle);

            Console.WriteLine("After Removal:");
            foreach (var film in library.GetFilms())
            {
                Console.WriteLine($"{film.Title} - {film.Director} - {film.Year}");
            }
        }
    }
    
}
