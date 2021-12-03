using System.IO;
using Movies.Models;
namespace Movies.Files
{
    public interface IFileRepo
    {
        Media GetMedia(StreamReader fileName);
    }
}