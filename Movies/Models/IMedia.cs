using System.Collections.Generic;

namespace Movies.Models
{
    public interface IMedia
    {
        int id { get; set; }
        string title { get; set; }
        List<string> genres { get; set; }

        void Display();
        void MakeNew();
    }
}