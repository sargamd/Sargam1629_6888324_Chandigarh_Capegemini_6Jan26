using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Library
{
    internal interface IFilm
    {
        string Title { get; set; }
        string Director { get; set; }
        int Year { get; set; }
    }
}
