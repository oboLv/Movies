using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using Movies.Models;

namespace Movies.Files
{
    public class MediaFile : IMediaFile
    {
        private readonly string _filename = "media.json";

        public void Add(Media media)
        {
            var json = JsonConvert.SerializeObject(media);
            var trim = string.Concat(json.Where(c => !char.IsWhiteSpace(c)));
            using (var writer = new StreamWriter(_filename))
            {
                writer.WriteLine(trim);
            }
        }

        public List<Media> GetMedia()
        {
            var list = new List<Media>();
            using (var reader = new StreamReader(_filename))
            {
                while(!reader.EndOfStream)
                {
                    list.Add(JsonConvert.DeserializeObject<Media>(reader.ReadLine()));
                }
            }
            return list;
        }
    }
}