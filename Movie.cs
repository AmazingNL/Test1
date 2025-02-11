using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal class Movie : Video
    {
        public Movie(string title, string director, int id, string genre, int duration) : base(id, title, genre, duration)
        {
            Director = director;
        }

        public string Director { get; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Movie] Title: {Title}, Genre: {Genre}, Duration: {Duration}, Director: {Director}, ID: {Id}");
        }
    }
}
