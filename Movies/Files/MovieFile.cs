using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Movies.Models;
using Newtonsoft.Json;

namespace Movies.Files
{
    public class MovieFile
    {
        private readonly string _filename = "movies.json";
        public void Add(Movie media)
        {
            var json = JsonConvert.SerializeObject(media);
            var trim = string.Concat(json.Where(c => !char.IsWhiteSpace(c)));
            using (var writer = new StreamWriter(_filename))
            {
                writer.WriteLine(trim);
            }
        }
        public List<Movie> GetMedia()
        {
            var list = new List<Movie>();
            using (var reader = new StreamReader(_filename))
            {
                while(!reader.EndOfStream)
                {
                    list.Add(JsonConvert.DeserializeObject<Movie>(reader.ReadLine()));
                }
            }
            return list;
        }
    }
}