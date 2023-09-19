using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Lab
{
    public class VideoGame : IComparable<VideoGame>
    {
       public string Name;
        public string Platform;
        public string year;
        public string genre;
        public string publisher;
        public  string NaSales;
        public string EuSales;
        public string JpSales;
        public string OtherSales;
        public string GlobalSales;
        public VideoGame videoGame;

       public VideoGame(string name, string platform, string year, string genre, string publisher, string naSales, string euSales, string jpSales, string otherSales, string globalSales)
        {
            Name = name;
            Platform = platform;
            this.year = year;
            this.genre = genre;
            this.publisher = publisher;
            NaSales = naSales;
            EuSales = euSales;
            JpSales = jpSales;
            OtherSales = otherSales;
            GlobalSales = globalSales;
        }

       public VideoGame()
        {
            Name = string.Empty;
            Platform = string.Empty;
            year= string.Empty;
            genre = "Strategy";
            publisher = string.Empty;
            NaSales = string.Empty;
            EuSales = string.Empty;
            JpSales = string.Empty;
            OtherSales = string.Empty;
            GlobalSales = string.Empty;

        }

       public VideoGame(VideoGame existingVideoGame)
        {

            existingVideoGame.Name = Name;
            existingVideoGame.Platform = Platform;
            existingVideoGame.year = year;
            existingVideoGame.genre = genre;
            existingVideoGame.publisher = publisher;
            existingVideoGame.NaSales = NaSales;
            existingVideoGame.EuSales = EuSales;
            existingVideoGame.JpSales = JpSales;
            existingVideoGame.OtherSales = OtherSales;
            existingVideoGame.GlobalSales = GlobalSales;
        }

        public override string ToString()
        {
            string VideoGameString = string.Empty;

            VideoGameString += $"Name: {Name}\n";
            VideoGameString += $"Platform: {Platform}\n";
            VideoGameString += $"Year: {year}\n";
            VideoGameString += $"Genre: {genre}\n";
            VideoGameString += $"Publisher: {publisher}\n";
            VideoGameString += $"Na-Sales: {NaSales}\n";
            VideoGameString += $"Eu-Sales: {EuSales}\n";
            VideoGameString += $"Jp-Sales: {JpSales}\n";
            VideoGameString += $"Other Sales: {OtherSales}\n";
            VideoGameString += $"Global Sales: {GlobalSales}\n";

            return VideoGameString;
        }

        public int CompareTo(VideoGame other)
        {
            if (other == null)
                return 1;

            // Compare titles in ascending order
            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
