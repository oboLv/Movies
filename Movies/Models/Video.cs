using System;
using System.Collections.Generic;
using System.Linq;
using Movies.Files;

namespace Movies.Models
{
    public class Video : IMedia
    {
        public string mediaType = "Video";
        public string format { get; set; }
        public int length { get; set; }
        public List<int> regions { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        public void Display()
        {
            var regionString = string.Join("/", regions);
            var genreString = string.Join("/", genres);
            Console.WriteLine($"{id, -5}{title, -50}{format, 6}{length, 6}{regionString, -5}{genreString}");
        }

        public void MakeNew()
        {
            var file = new MediaFile();
            var list = file.GetMedia();
            var ids = new List<int>();
            foreach (var item in list)
            {
                if (item.mediaType == "Video")
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

            System.Console.WriteLine("Enter format:");
            this.format = Console.ReadLine();

            System.Console.WriteLine("Enter length: ");
            this.length = Convert.ToInt32(Console.ReadLine());

            var newRegionBool = false;
            do
            {
                System.Console.Write("Enter region: ");
                this.regions.Add(Convert.ToInt32(Console.ReadLine()));
                System.Console.WriteLine("Add more regions? (Y/N)");
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
            } while (!newRegionBool);
        }
    }
}