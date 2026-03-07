using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Library
{
    internal interface IFilmLibrary
    {
        void AddFilm(IFilm film);
        void RemoveFilm(string title);
        List<IFilm> GetFilms();
        List<IFilm> SearchFilms(string query);
        int GetTotalFilmCount();
    }
}
