using System;
using System.Linq;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public DefaultTaxCalculator(bool developmentEnvironment = false)
        {
            DevelopmentEnvironment = developmentEnvironment;
        }
        public bool DevelopmentEnvironment { get; set; }

        private static readonly DateTime FirstOfJanuary2019 = new DateTime(2019, 1, 1);

        public override int CalculateTax(Vehicle vehicle)
        {
            if (DevelopmentEnvironment)
            {
                if ((FirstOfJanuary2019 - vehicle.DateOfFirstRegistration).TotalDays >= 365)
                {
                    switch (vehicle.FuelType)
                    {
                        case FuelType.Electric:
                            return 0;
                        case FuelType.AlternativeFuel:
                            return 130;
                        default:
                            return 140;
                    }
                }
                
                return 0;
            } 


                if (vehicle.ListPrice >= 40000)
                {
                    switch (vehicle.FuelType)
                    {
                        case FuelType.Electric:
                            return 310;
                        case FuelType.AlternativeFuel:
                            return 440;
                        default: return 450;
                    }
                }
                else
                {
                    // Todo
                    return 0;
                }
            }
            else
            {
                var emissions = vehicle.Co2Emissions;
                var totalTax = StaticEmissions.PetrolEmissionsDictionary.FirstOrDefault(dict => dict.Key >= emissions)
                    .Value;

                if (vehicle.FuelType == FuelType.AlternativeFuel)
                {
                    totalTax = StaticEmissions.AlternativeFuelEmissionsDictionary
                        .FirstOrDefault(dict => dict.Key >= emissions)
                        .Value;
                }

                if (vehicle.FuelType == FuelType.Diesel)
                {
                    totalTax = StaticEmissions.DieselEmissionsDictionary.FirstOrDefault(dict => dict.Key >= emissions)
                        .Value;
                }

                return totalTax;
            }

            /*var newEmissions = StaticEmissions.PetrolEmissionsDictionary;
            var answer = from newEmission
                    in newEmissions
                where newEmission.Key >= emissions
                select newEmission.Value;
            return answer;*/
        }
    }
}