using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public abstract class FileRepo
    {
        public FileRepo(string file)
        {
            fileName = file;
        }
        private string fileName { get; set; }

        public abstract Media GetMedia(StreamReader fileName);
    }
}