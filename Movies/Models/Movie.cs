using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movie : Media
    {
        public override void Display()
        {
            var genreString = string.Join("/", genres);
            
            Console.WriteLine($"{id, -5}{title, -50}{genreString, 2}");
        }
    }
}