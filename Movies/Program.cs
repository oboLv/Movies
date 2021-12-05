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
            var menu = new Menu();
            
            while (!exit)
            {
                var choice = menu.MainMenuSelection();

                if (choice == "1")
                {
                    menu.ViewProcess();
                }
                else if (choice == "2")
                {
                    menu.AddProcess();
                }
                else if (choice == "3")
                {
                    menu.Search();
                }
                else if (choice == "4")
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
