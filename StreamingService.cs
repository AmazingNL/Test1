using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal class StreamingService
    {
        private List<Video> Library = new List<Video>();
        private Dictionary<int, bool> WatchStatus = new Dictionary<int, bool>();

        public void Addvideo(Video video)
        {
            Library.Add(video);
            WatchStatus[video.Id] = false;
        }

        public Video FindByVideoById(int Id)
        {

            foreach (Video video in Library)
            {
                if (video.Id == Id)
                {
                    return video;
                }
            }
            throw new VideoNotFoundException($"Video with id {Id} not found");
        }

        public void WatchVideo(int Id)
        {
            Video video = FindByVideoById(Id);
            video.StartStream();
            video.EndStream();
            WatchStatus[video.Id] = true;
        }

        public List<Video> GetVideosByStatus(bool isWatched)
        {
            List<Video> videos = new List<Video>();
            foreach (Video video in Library)
            {
                if (isWatched && WatchStatus[video.Id])
                {
                    videos.Add(video);
                }
                else if (!isWatched && !WatchStatus[video.Id])
                {
                    videos.Add(video);
                }
            }
            return videos;
        }
        public int GetTotalDurationOfVideos(List<Video> video)
        {
            int totalDuration = 0;
            foreach (Video videos in video)
            {
                totalDuration += videos.Duration;
            }
            return totalDuration;
        }

        public void DisplayVideos(List<Video> videos)
        {
            foreach (Video video in videos)
            {
                video.DisplayInfo();
            }
        }

        public void DisplayReport()
        {
            List<Video> watchedVideo = GetVideosByStatus(true);
            List<Video> UnwatchedVideo = GetVideosByStatus(false);
            int totalDuration = GetTotalDurationOfVideos(watchedVideo);
            Console.WriteLine($"Streaming service report:");
            Console.WriteLine($"Total minutes watched: {totalDuration}");
            Console.WriteLine();
            Console.WriteLine("Watched videos");
            DisplayVideos(watchedVideo);
            Console.WriteLine();
            Console.WriteLine("Unwatched videos");
            DisplayVideos(UnwatchedVideo);

        }
    }
}
