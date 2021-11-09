using System;
using System.IO;
using System.Collections.Generic;
using Movies.Models;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var exit = false;

            
            while (!exit)
            {
                System.Console.WriteLine("1. View media");
                System.Console.WriteLine("2. Add media");
                System.Console.WriteLine("3. Exit");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    var viewBool = false;

                    while(!viewBool)
                    {
                        Console.Clear();
                        System.Console.WriteLine("1. View movies");
                        System.Console.WriteLine("2. View shows");
                        System.Console.WriteLine("3. View videos");
                        System.Console.WriteLine("4. Exit");
                        var viewChoice = Console.ReadLine();
                        if(viewChoice == "1")
                        {
                            var movieReader = new StreamReader("movies.csv");
                            var file = new MovieFile("movies.csv");
                            var more = false;
                            while(!more)
                            {
                                var loopy = false;
                                do{
                                for(int i = 0; i < 10; i++)
                                {
                                    try
                                    {
                                        file.GetMedia(movieReader).Display();
                                    }
                                    catch(NullReferenceException e)
                                    {
                                        break;
                                    }
                                }

                                System.Console.WriteLine("");
                                System.Console.WriteLine("View more? (Y/N)");
                                
                                var moreChoice = Console.ReadLine();
                                if(moreChoice.ToUpper() == "Y")
                                {
                                    loopy = true;
                                }
                                else if(moreChoice.ToUpper() == "N")
                                {
                                    more = true;
                                    movieReader.Close();
                                }
                                else
                                {
                                    loopy = false;
                                    System.Console.WriteLine("Try again.");

                                }
                                }while(loopy == true);
                            }
                        }
                        else if(viewChoice == "2")
                        {  
                            var showReader = new StreamReader("shows.csv");
                            var file = new MovieFile("shows.csv");
                            var more = false;
                            while(!more)
                            {
                                var loopy = false;
                                do{
                                for(int i = 0; i < 10; i++)
                                {
                                    try
                                    {
                                        file.GetMedia(showReader).Display();
                                    }
                                    catch(NullReferenceException e)
                                    {
                                        break;
                                    }
                                }

                                System.Console.WriteLine("");
                                System.Console.WriteLine("View more? (Y/N)");
                                
                                var moreChoice = Console.ReadLine();
                                if(moreChoice.ToUpper() == "Y")
                                {
                                    loopy = true;
                                }
                                else if(moreChoice.ToUpper() == "N")
                                {
                                    more = true;
                                    showReader.Close();
                                }
                                else
                                {
                                    loopy = false;
                                    System.Console.WriteLine("Try again.");

                                }
                                }while(loopy == true);
                            }
                        }
                        else if(viewChoice == "3")
                        {
                            var videoReader = new StreamReader("videos.csv");
                            var file = new MovieFile("videos.csv");
                            var more = false;
                            while(!more)
                            {
                                var loopy = false;
                                do{
                                for(int i = 0; i < 10; i++)
                                {
                                    try
                                    {
                                        file.GetMedia(videoReader).Display();
                                    }
                                    catch(NullReferenceException e)
                                    {
                                        break;
                                    }
                                }

                                System.Console.WriteLine("");
                                System.Console.WriteLine("View more? (Y/N)");
                                
                                var moreChoice = Console.ReadLine();
                                if(moreChoice.ToUpper() == "Y")
                                {
                                    loopy = true;
                                }
                                else if(moreChoice.ToUpper() == "N")
                                {
                                    more = true;
                                    videoReader.Close();
                                }
                                else
                                {
                                    loopy = false;
                                    System.Console.WriteLine("Try again.");

                                }
                                }while(loopy == true);
                            }
                        }
                        else if(viewChoice == "4")
                        {
                            viewBool = true;
                        }
                        else
                        {
                            System.Console.WriteLine("Try again.");
                        }
                    }
                }
                else if (choice == "2")
                {
                    
                }
                else if (choice == "3")
                {
                    exit = true;
                }
                else
                {
                    System.Console.WriteLine("Try again.");
                }
            }
        }
    }
}
