using Review_Lab;

namespace lab2
{

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<VideoGame>> gamesByPlatform = new Dictionary<string, List<VideoGame>>();
            string filePath = "D:\\Fall 23\\Server side\\Labs\\Lab2\\videogames.csv";

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] array = sr.ReadLine().Split(',');

                        VideoGame newGame = new VideoGame
                        {
                            Name = array[0],
                            Platform = array[1],
                            year = array[2],
                            genre = array[3],
                            publisher = array[4],
                            NaSales = array[5].Trim(),
                            EuSales = array[6],
                            JpSales = array[7].Trim(),
                            OtherSales = array[8],
                            GlobalSales = array[9]
                        };

                        if (gamesByPlatform.ContainsKey(newGame.Platform))
                        {
                            gamesByPlatform[newGame.Platform].Add(newGame);
                        }
                        else
                        {
                            gamesByPlatform[newGame.Platform] = new List<VideoGame> { newGame };
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Func<string, List<VideoGame>> getTop5Games = platform =>
            {
                if (gamesByPlatform.TryGetValue(platform, out var games))
                {
                    return games.OrderByDescending(g => g.GlobalSales).Take(5).ToList();
                }
                return new List<VideoGame>();
            };

            foreach (var platform in gamesByPlatform.Keys)
            {
                Console.WriteLine($"Top 5 games for {platform}:");
                var top5Games = getTop5Games(platform);

                foreach (var game in top5Games)
                {
                    Console.WriteLine($"{game.Name} - Global Sales: {game.GlobalSales}");
                }

                Console.WriteLine();
            }
        }
    }

}