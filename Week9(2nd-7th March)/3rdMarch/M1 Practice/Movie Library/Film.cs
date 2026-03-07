using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Library
{
    internal class Film:IFilm
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
    }
}
