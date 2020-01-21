using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Exercises
{
    public class Band
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
    }
}
