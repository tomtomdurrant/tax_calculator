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

        public static Dictionary<int, int> DieselEmissionsDictionary = new Dictionary<int, int>
        {
            {0, 0},
            {50, 25},
            {75, 105},
            {90, 125},
            {100, 145},
            {110, 165},
            {130, 205},
            {150, 515},
            {170, 830},
            {190, 1240},
            {225, 1760},
            {255, 2070},
            {MaxValue, 2070}
        };
    }
}