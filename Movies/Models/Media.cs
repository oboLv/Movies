using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public abstract class Media
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        public abstract void Display();
    }
}