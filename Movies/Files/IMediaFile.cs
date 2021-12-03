using System;
using System.Collections.Generic;
using System.Linq;
using Movies.Models;

namespace Movies.Files
{
    public interface IMediaFile
    {
        void Add(Media media);
        List<Media> GetMedia();
    }
}