using System.Linq;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            var emissions = vehicle.Co2Emissions;
            return StaticEmissions.PetrolEmissions.FirstOrDefault(pair => pair.Key >= emissions).Value;
        }
    }
}