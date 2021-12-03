using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies.Models
{

    public abstract class Media : IMedia
    {
        internal readonly string mediaType;

        public int id { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        public abstract void Display();

        public abstract void MakeNew();
    }
}