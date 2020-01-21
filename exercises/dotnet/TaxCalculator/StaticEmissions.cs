using System.Collections.Generic;
using static System.Int32;

namespace TaxCalculator
{
    public static class StaticEmissions
    {
        public static Dictionary<int, int> PetrolEmissionsDictionary = new Dictionary<int, int>
        {
            {0, 0},
            {50, 10},
            {75, 25},
            {90, 105},
            {100, 125},
            {110, 145},
            {130, 165},
            {150, 205},
            {170, 515},
            {190, 830},
            {225, 1240},
            {255, 1760},
            {MaxValue, 2070}
        };
        public static Dictionary<int, int> AlternativeFuelEmissionsDictionary = new Dictionary<int, int>()
        {
            {0, 0},
            {50, 0},
            {75, 15},
            {90, 95},
            {100, 115},
            {110, 135},
            {130, 155},
            {150, 195},
            {170, 505},
            {190, 820},
            {225, 1230},
            {255, 1750},
            {MaxValue, 2060}
        };

        public static Dictionary<int, int> DieselEmissionsDictionary = new Dictionary<int, int>
        {
            {0, 0},
            {50, 25},
            {75, 110},
            {90, 130},
            {100, 150},
            {110, 170},
            {130, 210},
            {150, 530},
            {170, 855},
            {190, 1280},
            {225, 1815},
            {255, 2135},
            {MaxValue, 2135}
        };
    }
}