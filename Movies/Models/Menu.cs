using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Movies.Models;
using Movies.Files;

namespace Movies
{
    public class Menu
    {
        public string MainMenuSelection()
        {
            System.Console.WriteLine("1. View media");
            System.Console.WriteLine("2. Add media");
            System.Console.WriteLine("3. Search media");
            System.Console.WriteLine("4. Exit");
            var selection = Console.ReadLine();
            return selection;
        }

        public void ViewProcess()
        {
            var exit = false;


            while (!exit)
            {
                System.Console.WriteLine("1. View movies");
                System.Console.WriteLine("2. View shows");
                System.Console.WriteLine("3. View videos");
                System.Console.WriteLine("4. Exit");
                var selection = Console.ReadLine();
                //  view movies
                if (selection == "1")
                {
                    var file = new MovieFile();
                    var list = file.GetMedia();
                    foreach (var media in list)
                    {
                        if (media.mediaType == "Movie")
                        {
                            media.Display();
                        }
                    }
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                // view shows
                else if (selection == "2")
                {
                    var file = new ShowFile();
                    var list = file.GetMedia();
                    foreach (var media in list)
                    {
                        if (media.mediaType == "Show")
                        {
                            media.Display();
                        }
                    }
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                // view videos
                else if (selection == "3")
                {
                    var file = new VideoFile();
                    var list = file.GetMedia();
                    foreach (var media in list)
                    {
                        if (media.mediaType == "Video")
                        {
                            media.Display();
                        }
                    }
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else if (selection == "4")
                {
                    exit = true;
                }
                else
                {
                    System.Console.WriteLine("Try again.");
                }
            }
        }

        public void AddProcess()
        {
            System.Console.WriteLine("1. Add movie");
            System.Console.WriteLine("2. Add show");
            System.Console.WriteLine("3. Add video");
            System.Console.WriteLine("4. Exit");
            var selection = Console.ReadLine();

            if (selection == "1")
            {
                var file = new MovieFile();
                var newMovie = new Movie();
                newMovie.MakeNew();
                file.Add(newMovie);
            }
            else if (selection == "2")
            {
                var file = new ShowFile();
                var newShow = new Show();
                newShow.MakeNew();
                file.Add(newShow);
            }
            else if (selection == "3")
            {
                var file = new VideoFile();
                var newVideo = new Video();
                newVideo.MakeNew();
                file.Add(newVideo);
            }
            else if (selection == "4")
            {

            }
        }


        public void Search()
        {
            var m = new MovieFile();
            var s = new ShowFile();
            var v = new VideoFile();

            var movieList = m.GetMedia();
            var showList = s.GetMedia();
            var videoList = v.GetMedia();

            System.Console.WriteLine("Enter title to search: ");
            var searchTitle = Console.ReadLine();

            var movieTitles = movieList.Where(c => c.title == searchTitle).Select(c => c.title);
            var showTitles = showList.Where(c => c.title == searchTitle).Select(c => c.title);
            var videoTitles = videoList.Where(c => c.title == searchTitle).Select(c => c.title);
            var totalTitles = movieTitles.Concat(showTitles).Concat(videoTitles).ToList();

            var numResults = totalTitles.Count();

            if (numResults == 0)
            {
                System.Console.WriteLine("No results found");
                System.Console.WriteLine("");
            }
            else
            {
                for (int i = 0; i <= numResults; i++)
                {
                    System.Console.WriteLine($"{i + 1}. {totalTitles[0]}");
                }
            }

            System.Console.WriteLine($"Total matches: {numResults}");
            System.Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}