using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Exercies
{
    public abstract class Band : IComparable
    {
        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }
        public Album[] Albums { get; set; }
        public string BandGenre { get; set; }

        public Band():this("Unknown", 0, "Unknown", "Unknown")
        {

        }

        public Band(string bandName, int yearFormed, string members, string bandGenre)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;
        }

        public override string ToString()
        {
            return $"{BandName}";
        }

        public int CompareTo(object obj)
        {
            Band objectCompare = obj as Band;
            int returnValue = this.BandName.CompareTo(objectCompare.BandName);
            return returnValue;
        }
    }

    public class RockBand : Band
    {
        public override string ToString()
        {
            return (this.BandName + " - Rock");
        }

        public RockBand()
        {
            Albums = new Album[10];
        }
    }

    public class PopBand : Band
    {
        public PopBand()
        {
            Albums = new Album[10];
        }

        public override string ToString()
        {
            return (this.BandName + " - Pop");
        }
    }

    public class IndieBand : Band
    {
        public override string ToString()
        {
            return (this.BandName + " - Indie");
        }

        public IndieBand()
        {
            Albums = new Album[10];
        }
    }
}
