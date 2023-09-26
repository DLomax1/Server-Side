using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title {  get; set; }

        public string series { get; set; }
        public string Country { get; set; }
        public string Details { get; set; }

        public BannedGame() 
        {
            Id = 0;
            Title = string.Empty;
            series = string.Empty;
            Country = string.Empty;
            Details = string.Empty;
        }

        public BannedGame(int id, string title, string series, string country, string details)
        {
            Id = id;
            Title = title;
            this.series = series;
            Country = country;
            Details = details;
        }

        public override string ToString()
        {
            string BannedString  = string.Empty;

            BannedString += $"Id: {Id}";
            BannedString += $"Title: {Title}";
            BannedString += $"Series: {series}";
            BannedString += $"Country: {Country}";
            BannedString += $"Details: {Details}";

            return BannedString;
        }
    }
}
