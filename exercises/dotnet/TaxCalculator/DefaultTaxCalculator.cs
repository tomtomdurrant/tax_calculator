using System.Linq;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            var emissions = vehicle.Co2Emissions;
            var totalTax = StaticEmissions.PetrolEmissionsDictionary.FirstOrDefault(dict => dict.Key >= emissions)
                .Value;
            
            if (vehicle.FuelType == FuelType.AlternativeFuel)
            {
                totalTax = StaticEmissions.AlternativeFuelEmissionsDictionary.FirstOrDefault(dict => dict.Key >= emissions)
                    .Value;
            }

            return totalTax;
            /*var newEmissions = StaticEmissions.PetrolEmissionsDictionary;
            var answer = from newEmission
                    in newEmissions
                where newEmission.Key >= emissions
                select newEmission.Value;
            return answer;*/
        }
    }
}