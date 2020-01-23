using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Exercies
{
    public class Album
    {
        static Random r = new Random();

        public string AlbumName { get; set; }
        public DateTime YearReleased { get; set; }

       /* private DateTime _yearReleased;

        public DateTime YearReleased
        {
            get
            {
                YearReleased = ;
            }
        }*/
        public int AlbumSales { get; set; }

        /*private DateTime GetRandomYear(DateTime startYear, DateTime endYear)
        {
            TimeSpan t = endYear = startYear;
            int numberYears = t.Year
            DateTime randomYear = startYear.AddYears(r.Next)
        }*/

        public Album(string albumName, DateTime yearReleased, int albumSales)
        {
            AlbumName = albumName;
            YearReleased = yearReleased;
            AlbumSales = albumSales;
        }

        public override string ToString()
        {
            return $"Album Name : {AlbumName}" +
                $"\nYear Released : {YearReleased}" +
                $"\nAlbum Sales : {AlbumSales}";
        }
    }
}
