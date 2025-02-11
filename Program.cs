namespace my_flix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }
        void start()
        {
            List<Video> videoList = new List<Video>()
            {
                new Movie("Grounding Day", "Harold", 1, "comedy", 101),
                new Movie("Tar", "Todd Field", 2, "Drama", 102),
                new TVEpisode("The Office", 1, 6, 3, "Comedy", 201),
                new TVEpisode("The cocain Bear", 2, 8, 4, "Action", 202)
            };
            foreach (Video video in videoList)
            {
                video.DisplayInfo();
            }
            Console.WriteLine();
            var streamingService = new StreamingService();

            streamingService.Addvideo(videoList[0]);
            streamingService.Addvideo(videoList[1]);
            streamingService.Addvideo(videoList[2]);
            streamingService.Addvideo(videoList[3]);

            streamingService.WatchVideo(1);
            streamingService.WatchVideo(2);

            streamingService.DisplayReport();

            VideoSaver videoSaver = new VideoSaver("../../../videos.txt");
            videoSaver.Save(videoList);
            Console.WriteLine();
            try
            {
                streamingService.FindByVideoById(999);
            }
            catch (VideoNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
