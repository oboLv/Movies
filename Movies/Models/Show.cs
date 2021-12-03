using System;
using System.Collections.Generic;
using System.Linq;
using Movies.Files;

namespace Movies.Models
{
    public class Show : IMedia
    {
        public string mediaType = "Show";
        public int season { get; set; }
        public int episode { get; set; }
        public List<string> writers { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        public void Display()
        {
            var writerString = string.Join("/", writers);
            var genreString = string.Join("/", genres);
            Console.WriteLine($"{id, -5}{title, -50}{season, 8}{episode, 8}{writerString, -30}{genreString}");
        }

        public void MakeNew()
        {
            var file = new MediaFile();
            var list = file.GetMedia();
            var ids = new List<int>();
            foreach (var item in list)
            {
                if (item.mediaType == "Show")
                {
                    ids.Add(item.id);
                }
            }
            this.id = ids.Max() + 1;
            System.Console.WriteLine("Enter title:");
            this.title = Console.ReadLine();

            var newGenreBool = false;
            do
            {
                System.Console.Write("Enter genre: ");
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

            System.Console.WriteLine("Enter number of seasons:");
            // needs error handling
            this.season = Convert.ToInt32(Console.ReadLine());

            this.episode = Convert.ToInt32(Console.ReadLine());

            var newWriterBool = false;
            do
            {
                System.Console.Write("Enter writer: ");
                this.writers.Add(Console.ReadLine());
                System.Console.WriteLine("Add more writers? (Y/N)");
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
            } while (!newWriterBool);
        }
    }
}