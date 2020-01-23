using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Exercies
{
    public class Album
    {
        public string AlbumName { get; set; }
        public DateTime YearReleased { get; set; }
        public int AlbumSales { get; set; }

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
