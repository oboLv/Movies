using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Movies.Models
{
    public class ShowFile : FileRepo
    {
        public ShowFile(string file) : base(file)
        {
        }

        public override Media GetMedia(StreamReader sr)
        {
            var line = sr.ReadLine();
            
            string[] split = line.Split(",");
            var a = new Movie();
            a.id = Convert.ToInt32(split[0]);
            a.title = split[1];
            a.genres = split[2].Split("|").ToList<string>();

            return a;
        }
    }
}