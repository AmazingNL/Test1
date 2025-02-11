using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal class VideoSaver
    {
        private string FilePath;

        public VideoSaver(string filePath)
        {
            FilePath = filePath;
        }

        public void Save(List<Video> videos)
        {
            try
            {
                using(StreamWriter streamWriter = new StreamWriter(FilePath))
                {
                    foreach(Video video in videos)
                    {
                        string type = video.GetType().Name;
                        if(type == "Movie")
                        {
                            Movie movie = (Movie)video;
                            streamWriter.WriteLine($"{type}|{video.Id}|{video.Title}|{video.Genre}|{video.Duration}|{movie.Director}");
                        }
                        else if (type == "TVEpisode")
                        {
                            TVEpisode tvEpisode = (TVEpisode)video;
                            streamWriter.WriteLine($"{type}|{video.Id}|{video.Title}|{video.Genre}|{video.Duration}|{tvEpisode.SeasonNumber}|{tvEpisode.EpisodeNumber}");
                        }
                    }

                }
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public List<Video> Load()
        {
            List<Video> videos = new List<Video>();
            try
            {
                using (StreamReader streamReader = new StreamReader(FilePath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        string[] data = line.Split("|");
                        if (data[0] == "Movie")
                        {
                            Movie movie = new(
                                data[1],
                                data[2],
                                int.Parse(data[3]),
                                data[4],
                                int.Parse(data[5])
                            );
                            videos.Add(movie);
                        }
                        else
                        {
                            TVEpisode tVEpisode = new(
                                data[1],
                                int.Parse(data[2]),
                                int.Parse(data[3]),
                                int.Parse(data[4]),
                                data[5],
                                int.Parse(data[6])
                            );
                            videos.Add(tVEpisode);
                        }
                    }
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }
            return videos;

        }
    }
}
