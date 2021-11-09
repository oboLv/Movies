using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies.Models
{
    public class Video : Media
    {
        public string format { get; set; }
        public int length { get; set; }
        public List<int> regions { get; set; }

        public override void Display()
        {
            var regionString = string.Join("/", regions);
            var genreString = string.Join("/", genres);
            Console.WriteLine($"{id, -5}{title, -50}{format, 6}{length, 6}{regionString, -5}{genreString}");
        }
    }
}