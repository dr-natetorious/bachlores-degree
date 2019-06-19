using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Einstean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einstein's Problem Space Reducer");
            Console.WriteLine("================================");
            Console.WriteLine("(c) Nate Bachmeier");
            Console.WriteLine("http://wasntnate.com");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Original Problem from: http://www.stanford.edu/~laurik/fsmbook/examples/Einstein%27sPuzzle.html");
            Console.WriteLine();

            //
            //  Get list of possible combinations on 5 characteristics
            var houses = CreateInitialDataSet();
            Console.WriteLine("Initial Search Space: {0}", houses.Count);


            //1.    The Englishman lives in the red house.
            ApplyFilter(houses, 
                house=> house.Nationality == Nationality.English,
                house=> house.Color == Color.Red);

            ApplyFilter(houses,
                house => house.Color == Color.Red,
                house => house.Nationality == Nationality.English);
            Console.WriteLine("Rule #1: The Englishman lives in the red house.");
            Console.WriteLine("Search Space: {0}", houses.Count);

            //2.    The Swede keeps dogs
            ApplyFilter(houses, 
                house=> house.Nationality == Nationality.Swede,
                house=> house.Pet == Pet.Dog);
            
            ApplyFilter(houses,
                house => house.Pet == Pet.Dog,
                house => house.Nationality == Nationality.Swede);
            Console.WriteLine("Rule #2: The Swede keeps dogs.");
            Console.WriteLine("Search Space: {0}", houses.Count);

            //3.    The Dane drinks tea
            ApplyFilter(houses, 
                house=> house.Nationality == Nationality.Dane,
                house=> house.Drink == Drink.Tea);

            ApplyFilter(houses,
                house => house.Drink == Drink.Tea,
                house => house.Nationality == Nationality.Dane);

            Console.WriteLine("Rule #3: The Dane drinks tea.");
            Console.WriteLine("Search Space: {0}", houses.Count);

            //5.    The owner of the green house drinks coffee
            ApplyFilter(houses,
                house => house.Color == Color.Green,
                house => house.Drink == Drink.Coffee);

            ApplyFilter(houses,
                house => house.Drink == Drink.Coffee,
                house => house.Color == Color.Green);

            Console.WriteLine("Rule #5: The owner of the green house drinks coffee.");
            Console.WriteLine("Search Space: {0}", houses.Count);

            //6.    The Pall Mall smoker keeps birds. 
            ApplyFilter(houses,
                house => house.Smoke == Smoke.Pallmall,
                house => house.Pet == Pet.Bird);

            ApplyFilter(houses,
                house => house.Pet == Pet.Bird,
                house => house.Smoke == Smoke.Pallmall);

            Console.WriteLine("Rule #6: The Pall Mall smoker keeps birds. ");
            Console.WriteLine("Search Space: {0}", houses.Count);

            //7.    The owner of the yellow house smokes Dunhills
            ApplyFilter(houses,
                house => house.Color == Color.Yellow,
                house => house.Smoke == Smoke.Dunhill);

            ApplyFilter(houses,
                house => house.Smoke == Smoke.Dunhill,
                house => house.Color == Color.Yellow);

            Console.WriteLine("Rule #7: The owner of the yellow house smokes Dunhills. ");
            Console.WriteLine("Search Space: {0}", houses.Count);


            //11.    The man who smokes Blue Masters drinks bier
            ApplyFilter(houses,
                house => house.Smoke == Smoke.BlueMaster,
                house => house.Drink == Drink.Bier);

            ApplyFilter(houses,
                house => house.Drink == Drink.Bier,
                house => house.Smoke == Smoke.BlueMaster);

            Console.WriteLine("Rule #11: The man who smokes Blue Masters drinks bier.");
            Console.WriteLine("Search Space: {0}", houses.Count);

            //13.   German smokes prince
            ApplyFilter(houses, 
                house => house.Nationality == Nationality.German, 
                house => house.Smoke== Smoke.Prince);

            ApplyFilter(houses,
                house => house.Smoke == Smoke.Prince,
                house => house.Nationality == Nationality.German);
            Console.WriteLine("Rule #13: German smokes prince.");
            Console.WriteLine("Search Space: {0}", houses.Count);

            //
            //  Expand Filtered list to include Location
            ExpandWithLocationInformation(ref houses);
            Console.WriteLine("Introduced Location Possibles...");
            Console.WriteLine("Search Space: {0}", houses.Count);
            //


            //8.    The man in the center house drinks milk
            ApplyFilter(houses,
                house => house.Location == Location.Third,
                house => house.Drink == Drink.Milk);

            ApplyFilter(houses,
                house => house.Drink == Drink.Milk,
                house => house.Location == Location.Third);

            Console.WriteLine("Rule #8: The man in the center house drinks milk.");
            Console.WriteLine("Search Space: {0}", houses.Count);

            //9.   The Norwegian lives in the first house
            //14.  The Norwegian lives next to the blue house  
            ApplyFilter(houses,
                house => house.Nationality == Nationality.Norweign,
                house => house.Location == Location.First);
            ApplyFilter(houses,
                house => house.Location == Location.First,
                house => house.Nationality == Nationality.Norweign);
            
            ApplyFilter(houses,
                house => house.Color == Color.Blue,
                house => house.Location == Location.Second);
            ApplyFilter(houses,
                house => house.Location == Location.Second,
                house => house.Color == Color.Blue);

            ApplyFilter(houses,
                house => house.Nationality == Nationality.Norweign,
                house => house.Color != Color.Blue);

            ApplyFilter(houses,
                house => house.Color == Color.Blue,
                house => house.Nationality != Nationality.Norweign);

            Console.WriteLine("Rule #9: The Norwegian lives in the first house");
            Console.WriteLine("  and Rule #14: The Norwegian lives next to the blue house ");
            Console.WriteLine("Search Space: {0}", houses.Count);


            //4.    The green house is just to the left of the white one
            //          Green cannot be the end house 
            ApplyFilter(houses,
                house => house.Color == Color.Green,
                house => house.Location != Location.Fifth);

            ApplyFilter(houses,
                house => house.Location == Location.Fifth,
                house => house.Color != Color.Green);

            
            var rule4 = (from h in houses
                         where h.Color == Color.Green
                         &&
                         (from n in houses
                          where n.Location == h.Location + 1
                              && n.Color == Color.White
                          select n).FirstOrDefault() != null
                         select h).ToArray();
            Console.WriteLine("Rule 4: {0}", rule4.Count());

            foreach(var guess in rule4)
            {
                Console.WriteLine("\t{0}", guess);
            }

            //10.   The Blend smoker has a neighbor who keeps cats
            var rule10 = (from h in houses
                          where h.Smoke == Smoke.Blend
                          &&
                              (from n in houses
                               where n.Smoke != Smoke.Blend
                               && n.Pet == Pet.Cat
                               && n.Location >= h.Location - 1
                               && n.Location <= h.Location + 1
                               select n).FirstOrDefault() != null
                          select h).ToArray();
            Console.WriteLine("Rule 10: {0}", rule10.Count());
            foreach (var guess in rule10)
            {
                Console.WriteLine("\t{0}", guess);
            }

            //15.   The Blend smoker has a neighbor who drinks water
            var rule15 = (from h in houses
                          where h.Smoke == Smoke.Blend
                          && (from n in houses
                              where n.Smoke != Smoke.Blend
                              && n.Drink == Drink.Water
                              && n.Location >= h.Location - 1
                              && n.Location <= h.Location + 1
                              select n).FirstOrDefault() != null
                          select h).ToArray();
            Console.WriteLine("Rule 15: {0}", rule15.Count());
            foreach (var guess in rule15)
            {
                Console.WriteLine("\t{0}", guess);
            }


            //12.   The man who keeps horses lives next to the Dunhill smoker
            var rule12 = (from h in houses
                          where h.Pet == Pet.Horse &&
                              (from n in houses
                               where n.Pet != Pet.Horse
                               && n.Smoke == Smoke.Dunhill
                               && n.Location >= h.Location - 1
                               && n.Location <= h.Location + 1
                               select n).FirstOrDefault() != null
                          select h).ToArray();
            Console.WriteLine("Rule 12: {0}", rule12.Count());
            foreach (var guess in rule12)
            {
                Console.WriteLine("\t{0}", guess);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Issue a <paramref name="selectPredicate"/>, then remove items that do not match a <paramref name="keepPredicate"/>
        /// </summary>
        /// <param name="houses">All the possible house combinations to reduce</param>
        /// <param name="selectPredicate"></param>
        /// <param name="keepPredicate"></param>
        private static void ApplyFilter(List<House> houses, Func<House,bool> selectPredicate, Func<House,bool> keepPredicate)
        {
            var removeIndexes = new List<int>();
            for (var i = 0; i < houses.Count; i++)
            {
                var house = houses[i];

                if (selectPredicate(house))
                {
                    if (false == keepPredicate(house))
                        removeIndexes.Add(i);
                }
            }

            foreach(var ix in removeIndexes.OrderByDescending(i=>i))
            {
                houses.RemoveAt(ix);
            }

            //Console.WriteLine("Possible Combinations: {0}", houses.Count);
        }

        /// <summary>
        /// Create the initial data set
        /// </summary>
        /// <returns>Creates a 5^5 list of all possible combinations</returns>
        private static List<House> CreateInitialDataSet()
        {
            var houses = new List<House>(5 * 5 * 5 * 5 * 5 * 5);

            for (var a = 0; a < 5; a++)
                for (var b = 0; b < 5; b++)
                    for (var c = 0; c < 5; c++)
                        for (var d = 0; d < 5; d++)
                            for (var e = 0; e < 5; e++)
                            {
                                var house = new House
                                {
                                    Nationality = (Nationality)a,
                                    Color = (Color)b,
                                    Pet = (Pet)c,
                                    Drink = (Drink)d,
                                    Smoke = (Smoke)e,
                                };

                                houses.Add(house);
                            }
            return houses;
        }

        /// <summary>
        /// Expand the <paramref name="houses"/> search space to include <see cref="T:Location"/> possibles
        /// </summary>
        private static void ExpandWithLocationInformation(ref List<House> houses)
        {
            var result = new List<House>(houses.Count * 5);

            foreach(var house in houses)
            {
                for(var i=0; i<5; i++)
                {
                    result.Add(new House
                        {
                            Nationality = house.Nationality,
                            Pet = house.Pet,
                            Smoke = house.Smoke,
                            Color = house.Color,
                            Drink = house.Drink,
                            Location = (Location)i
                        });
                }
            }

            houses.Clear();
            houses.AddRange(result);
        }
    }
}
