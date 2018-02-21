using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicsMedalStandings.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int NumGoldMedal { get; set; }
        public int NumSilverMedal { get; set; }
        public int NumBronzeMedal { get; set; }
    }
}
