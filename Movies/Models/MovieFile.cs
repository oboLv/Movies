using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieFile : FileRepo
    {
        public MovieFile(string file) : base(file)
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