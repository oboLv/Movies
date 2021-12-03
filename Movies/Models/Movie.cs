using System;
using System.Collections.Generic;
using System.Linq;
using Movies.Files;

namespace Movies.Models
{
    public class Movie : IMedia
    {
        public string mediaType = "Movie";

        public int id { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        public void Display()
        {
            var genreString = string.Join("/", genres);

            Console.WriteLine($"{id,-5}{title,-50}{genreString,2}");
        }

        public void MakeNew()
        {
            var file = new MediaFile();
            var list = file.GetMedia();
            var ids = new List<int>();
            foreach (var item in list)
            {
                if (item.mediaType == "Movie")
                {
                    ids.Add(item.id);
                }
            }
            if (ids.Count() > 0)
            {
            this.id = ids.Max() + 1;
            }
            else
            {
                this.id = 1;
            }
            System.Console.WriteLine("Enter title:");
            this.title = Console.ReadLine();
            var newGenreBool = false;
            do
            {
                System.Console.Write("Enter genre: ");
                this.genres = new List<string>();
                this.genres.Add(Console.ReadLine());
                System.Console.WriteLine("Add more genres? (Y/N)");
                var moreGenres = Console.ReadLine();
                if (moreGenres.ToUpper() == "Y")
                {
                    break;
                }
                else if (moreGenres.ToUpper() == "N")
                {
                    newGenreBool = true;
                }
                else
                {
                    System.Console.WriteLine("Try again.");
                }
            } while (!newGenreBool);
        }
    }
}