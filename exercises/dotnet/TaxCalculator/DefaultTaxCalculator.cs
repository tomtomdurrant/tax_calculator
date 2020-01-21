using System;
using System.Linq;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        private static readonly DateTime FirstOfJanuary2019 = new DateTime(2019, 1, 1);

        public override int CalculateTax(Vehicle vehicle)
        {
            int totalTax;
            if ((FirstOfJanuary2019 - vehicle.DateOfFirstRegistration).TotalDays >= 365)
            {
                if (vehicle.ListPrice >= 40000)
                {
                    switch (vehicle.FuelType)
                    {
                        case FuelType.Electric:
                            totalTax = 310;
                            break;
                        case FuelType.AlternativeFuel:
                            totalTax = 440;
                            break;
                        default:
                            totalTax = 450;
                            break;
                    }
                }
                else
                {
                    switch (vehicle.FuelType)
                    {
                        case FuelType.Electric:
                            totalTax = 0;
                            break;
                        case FuelType.AlternativeFuel:
                            totalTax = 130;
                            break;
                        default:
                            totalTax = 140;
                            break;
                    }
                }
            }
            else
            {
                var emissions = vehicle.Co2Emissions;
                totalTax = StaticEmissions.PetrolEmissionsDictionary.FirstOrDefault(dict => dict.Key >= emissions)
                    .Value;

                if (vehicle.FuelType == FuelType.AlternativeFuel)
                {
                    totalTax = StaticEmissions.AlternativeFuelEmissionsDictionary
                        .FirstOrDefault(dict => dict.Key >= emissions)
                        .Value;
                }

                if (vehicle.FuelType == FuelType.Diesel)
                {
                    totalTax = StaticEmissions.DieselEmissionsDictionary
                        .FirstOrDefault(dict => dict.Key >= emissions)
                        .Value;
                }
            }

            return totalTax;
        }
    }
}