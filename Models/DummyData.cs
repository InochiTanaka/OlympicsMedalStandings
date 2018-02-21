using OlympicsMedalStandings.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicsMedalStandings.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (!db.Countries.Any())
            {
                db.Countries.Add(new Country
                {
                    CountryName = "Netherlands",
                    NumGoldMedal = 6,
                    NumSilverMedal = 5,
                    NumBronzeMedal = 3,
                });

                db.Countries.Add(new Country
                {
                    CountryName = "France",
                    NumGoldMedal = 5,
                    NumSilverMedal = 4,
                    NumBronzeMedal = 4,
                });

                db.Countries.Add(new Country
                {
                    CountryName = "Norway",
                    NumGoldMedal = 11,
                    NumSilverMedal = 11,
                    NumBronzeMedal = 8,
                });

                db.Countries.Add(new Country
                {
                    CountryName = "Germany",
                    NumGoldMedal = 11,
                    NumSilverMedal = 7,
                    NumBronzeMedal = 8,
                });

                db.Countries.Add(new Country
                {
                    CountryName = "Canada",
                    NumGoldMedal = 9,
                    NumSilverMedal = 5,
                    NumBronzeMedal = 6,
                });

                db.SaveChanges();
            }
        }
    }
}
