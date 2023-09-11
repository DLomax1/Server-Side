
using System.Data;
using System.Xml;

namespace Review_Lab
{
    
    public class Program
    {
        public string Name;
        public string Platform;
        public string year;
        public string genre;
        public string publisher;
        public double NaSales;
        public double EuSales;
        public double JpSales;
        public double OtherSales;
        public double GlobalSales;


        //Chosen Publisher Ubisoft 

        public static void Main(string[] args)
        {
            string filePath = "E:\\Fall 23\\Server side\\Labs\\Review Lab\\videogames.csv";
            Readin(filePath);

            Console.WriteLine();
        }

        public static void Readin(string filePath)
        {
            List<VideoGame> ReadGames = new List<VideoGame>();
            using (StreamReader sr = new StreamReader(filePath))
            {                
                while(!sr.EndOfStream)
                {
                    string[] array = sr.ReadLine().Split(',');

                    VideoGame NewGame = new VideoGame();

                    NewGame.Name = array[0];
                    NewGame.Platform = array[1];
                    NewGame.year = array[2];
                    NewGame.genre = array[3];

                    NewGame.publisher = array[4];
                    NewGame.NaSales = array[5].Trim();
                    NewGame.EuSales = array[6];
                    NewGame.JpSales = array[7].Trim();
                    NewGame.OtherSales = array[8];
                    NewGame.GlobalSales = array[9];

                    ReadGames.Add(NewGame);
                }




                


            }
            List<VideoGame> filteredList = ReadGames.Where(VideoGame => VideoGame.publisher == "Sega").ToList();
            filteredList.Sort();

            for (int i = 0; i < filteredList.Count; i++)
            {
                Console.WriteLine(filteredList[i]); ;
            }

            decimal Percentage = ReadGames.Count / filteredList.Count;
            Math.Round(Percentage, 2);
            Console.WriteLine($"{filteredList.Count} out of {ReadGames.Count} games are developed by Sega");
            Console.WriteLine($"The percentage of sega games in comparison to the list is {Percentage}%");

            List<VideoGame> SelectedGenre = filteredList.Where(VideoGame => VideoGame.genre == "Role-Playing").ToList();

            for (int i = 0; i < SelectedGenre.Count; i++)
            {
                Console.WriteLine(SelectedGenre[i]); ;
            }
            Console.WriteLine($"Out of {filteredList.Count} games {SelectedGenre.Count} are Role-Playing games " +
                $"which is {filteredList.Count / SelectedGenre.Count}%.");


            Console.WriteLine("Which publisher would you like to look-up?");
            string UserSearch = Console.ReadLine();


            List<VideoGame> SearchList = ReadGames.Where(VideoGame => VideoGame.publisher == UserSearch).ToList();

            for (int i = 0; i < SearchList.Count; i++)
            {
                Console.WriteLine(SearchList[i]);
            }
            Console.WriteLine($"There are {ReadGames.Count} total games of which {SearchList.Count} are made by {UserSearch} which is {ReadGames.Count / SearchList.Count}%");

            Console.WriteLine("Which genre would you like to look up?" );
            string UserGenre = Console.ReadLine();

            List<VideoGame> GenreSearch = ReadGames.Where(VideoGame => VideoGame.genre == UserGenre).ToList();

            for (int i = 0; i < GenreSearch.Count; i++)
            {
                Console.WriteLine($"There are {ReadGames.Count} total games of which {GenreSearch.Count} are of the {UserGenre} genre which is {ReadGames.Count / GenreSearch.Count}%");
            }
            

        }
        
      
    }
}