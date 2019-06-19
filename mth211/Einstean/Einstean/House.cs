using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Einstean
{
    /// <summary>
    /// Represents a known combination
    /// </summary>
    class House
    {
        public House()
        {
            Nationality = Nationality.Unknown;
            Color = Color.Unknown;
            Pet = Pet.Unknown;
            Drink = Drink.Unknown;
            Smoke = Smoke.Unknown;
            Location = Location.Unknown;
        }

        public Nationality Nationality;
        public Color Color;
        public Pet Pet;
        public Drink Drink;
        public Smoke Smoke;
        public Location Location;

        public override string ToString()
        {
            if (Location == Location.Unknown)
                return string.Format("{0} {1} {2} {3} {4}",
                Nationality, Color, Pet, Drink, Smoke);

            return string.Format("{0} {1} {2} {3} {4} {5}",
                Nationality, Color, Pet, Drink, Smoke, Location);
        }
    }
}
