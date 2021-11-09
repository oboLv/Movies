using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Movies.Models
{
    public class VideoFile : FileRepo
    {
        public VideoFile(string file) : base(file)
        {
        }

        public override Media GetMedia(StreamReader sr)
        {
            var line = sr.ReadLine();

            string[] split = line.Split(",");
            var a = new Video();
            a.id = Convert.ToInt32(split[0]);
            a.title = split[1];
            a.format = split[2];
            a.length = Convert.ToInt32(split[3]);

            var regions = split[4].Split("|");
            foreach (var i in regions)
            {
                var n = Int32.Parse(i);
                a.regions.Add(n);
            }
            
            a.genres = split[5].Split("|").ToList<string>();


            return a;
        }
    }
}