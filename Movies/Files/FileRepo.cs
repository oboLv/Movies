using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Movies.Models;

namespace Movies.Files
{

    public abstract class FileRepo : IFileRepo
    {
        public FileRepo(string file)
        {
            fileName = file;
        }
        private string fileName { get; set; }

        public abstract Media GetMedia(StreamReader fileName);
    }
}