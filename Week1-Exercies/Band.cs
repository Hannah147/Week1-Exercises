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

        public Band():this("Unknown", 0, "Unknown")
        {

        }

        public Band(string bandName, int yearFormed, string members)
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
        private string bandGenre;
        public string BandGenre
        {
            get { return bandGenre; }
            set
            {
                bandGenre = "Rock";
            }
        }

        public override string ToString()
        {
            return $"{BandName} \t\t {BandGenre}";
        }
    }

    public class PopBand : Band
    {
        public string BandGenre { get; set; }

        public override string ToString()
        {
            return $"{BandName} \t\t {BandGenre}";
        }
    }

    public class IndieBand : Band
    {
        public string BandGenre { get; set; }

        public override string ToString()
        {
            return $"{BandName} \t\t {BandGenre}";
        }
    }
}
