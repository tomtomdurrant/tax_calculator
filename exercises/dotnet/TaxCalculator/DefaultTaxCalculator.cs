using System.Linq;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            var emissions = vehicle.Co2Emissions;
            /*var newEmissions = StaticEmissions.PetrolEmissionsDictionary;
            var answer = from newEmission
                    in newEmissions
                where newEmission.Key >= emissions
                select newEmission.Value;
            return answer;*/
            return StaticEmissions.PetrolEmissionsDictionary.FirstOrDefault(dict => dict.Key >= emissions).Value;
        }
    }
}