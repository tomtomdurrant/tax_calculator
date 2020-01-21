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

        public override int CalculateTax(Vehicle vehicle)
        {
            if (DevelopmentEnvironment)
            {
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