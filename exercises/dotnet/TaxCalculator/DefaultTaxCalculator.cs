using System;
using System.Linq;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        private static readonly DateTime FirstOfJanuary2019 = new DateTime(2019, 1, 1);

        public override int CalculateTax (Vehicle vehicle)
        {
            bool isVehicleOlderThanOneYear = (FirstOfJanuary2019 - vehicle.DateOfFirstRegistration).TotalDays >= 365;
            bool isVehicleOverFortyThousand = vehicle.ListPrice >= 40000;
            int vehicleTax;

            if (isVehicleOlderThanOneYear)
            {
                if (isVehicleOverFortyThousand)
                {
                    vehicleTax = CalculateTaxBasedOnFuelTypeExpensive(vehicle.FuelType);
                }
                else
                {
                    vehicleTax = CalculateTaxBasedOnFuelTypeForCheap(vehicle.FuelType);
                }
            }
            else
            {
                if (vehicle.IsRde2Compliant)
                {
                    vehicleTax = CalculateTaxBasedOnEmissionsForRde2Compliant(vehicle.Co2Emissions, vehicle.FuelType);
                }
                else
                {
                    vehicleTax = CalculateTaxBasedOnEmissions(vehicle.Co2Emissions, vehicle.FuelType);
                }
            }

            return vehicleTax;
        }

        private int CalculateTaxBasedOnEmissionsForRde2Compliant(int vehicleCo2Emissions, FuelType vehicleFuelType)
        {
            int totalTax;
            var emissions = vehicleCo2Emissions;
            totalTax = StaticEmissions.NewPetrolAndRDE2Compliant.FirstOrDefault(dict => dict.Key >= emissions)
                .Value;
            
            return totalTax;

        }

        private int CalculateTaxBasedOnEmissions(int vehicleCo2Emissions, FuelType vehicleFuelType)
        {
            int totalTax;
            var emissions = vehicleCo2Emissions;
            totalTax = StaticEmissions.PetrolEmissionsDictionary.FirstOrDefault(dict => dict.Key >= emissions)
                .Value;

            if (vehicleFuelType == FuelType.AlternativeFuel)
            {
                totalTax = StaticEmissions.AlternativeFuelEmissionsDictionary
                    .FirstOrDefault(dict => dict.Key >= emissions)
                    .Value;
            }

            if (vehicleFuelType == FuelType.Diesel)
            {
                totalTax = StaticEmissions.DieselEmissionsDictionary
                    .FirstOrDefault(dict => dict.Key >= emissions)
                    .Value;
            }

            return totalTax;
        }
        

        private static int CalculateTaxBasedOnFuelTypeForCheap(FuelType fuelType)
        {
            int totalTax;
            switch (fuelType)
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

            return totalTax;
        }

        private static int CalculateTaxBasedOnFuelTypeExpensive(FuelType fuelType)
        {
            int totalTax;
            switch (fuelType)
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

            return totalTax;
        }
        
    }
}