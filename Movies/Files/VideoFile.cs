using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Movies.Models;
using Newtonsoft.Json;
namespace Movies.Files
{
    public class VideoFile
    {
        private readonly string _filename = "videos.json";  
        public void Add(Video media)
        {
            var json = JsonConvert.SerializeObject(media);
            var trim = string.Concat(json.Where(c => !char.IsWhiteSpace(c)));
            using (var writer = new StreamWriter(_filename))
            {
                writer.WriteLine(trim);
            }
        }
        public List<Video> GetMedia()
        {
            var list = new List<Video>();
            using (var reader = new StreamReader(_filename))
            {
                while(!reader.EndOfStream)
                {
                    list.Add(JsonConvert.DeserializeObject<Video>(reader.ReadLine()));
                }
            }
            return list;
        }
    }
}