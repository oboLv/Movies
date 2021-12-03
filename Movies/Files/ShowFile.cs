using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Movies.Models;
using Newtonsoft.Json;
namespace Movies.Files
{
    public class ShowFile
    {
        private readonly string _filename = "shows.json";
        public void Add(Show media)
        {
            var json = JsonConvert.SerializeObject(media);
            var trim = string.Concat(json.Where(c => !char.IsWhiteSpace(c)));
            using (var writer = new StreamWriter(_filename))
            {
                writer.WriteLine(trim);
            }
        }
        public List<Show> GetMedia()
        {
            var list = new List<Show>();
            using (var reader = new StreamReader(_filename))
            {
                while(!reader.EndOfStream)
                {
                    list.Add(JsonConvert.DeserializeObject<Show>(reader.ReadLine()));
                }
            }
            return list;
        }
    }
}