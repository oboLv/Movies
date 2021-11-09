using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Show : Media
    {
        public int season { get; set; }
        public int episode { get; set; }
        public List<string> writers { get; set; }

        public override void Display()
        {
            var writerString = string.Join("/", writers);
            var genreString = string.Join("/", genres);
            Console.WriteLine($"{id, -5}{title, -50}{season, 8}{episode, 8}{writerString, -30}{genreString}");
        }
    }
}