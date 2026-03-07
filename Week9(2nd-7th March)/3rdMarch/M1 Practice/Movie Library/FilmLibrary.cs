using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Library
{
    internal class FilmLibrary:IFilmLibrary
    {
        private List<IFilm> films = new List<IFilm>();

        public void AddFilm(IFilm film)
        {
            films.Add(film);
        }

        public void RemoveFilm(string title)
        {
            var film = films.FirstOrDefault(f =>
                f.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (film != null)
            {
                films.Remove(film);
            }
        }

        public List<IFilm> GetFilms()
        {
            return films;
        }

        public List<IFilm> SearchFilms(string query)
        {
            return films.Where(f =>
                f.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                f.Director.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public int GetTotalFilmCount()
        {
            return films.Count;
        }
    }
}
