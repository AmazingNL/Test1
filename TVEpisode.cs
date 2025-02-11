using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal class TVEpisode : Video
    {
        public TVEpisode(string title, int seasonNumber, int episodNumber, int id, string genre, int duration) : base(id, title, genre, duration)
        {
            SeasonNumber = seasonNumber;
            EpisodeNumber = episodNumber;
        }

        public int SeasonNumber { get;}
        public int EpisodeNumber { get;}

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Movie] Title: {Title}, Genre: {Genre}, Duration: {Duration}, Season: {SeasonNumber}, EpisodeNumber: {EpisodeNumber}, ID: {Id}");
        }
    }
}
