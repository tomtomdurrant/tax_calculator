using System;

namespace TaxCalculator
{
    public class TaxCalculator2019 : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            int cost = 0;

            if (Year == vehicle.DateOfFirstRegistration.Year)
            {
                cost = CalculateFirstYearsTax(vehicle);
            }
            else
            {
                cost = CalculateTaxForSubsequentYears(vehicle);
            }

            return cost;
        }

        private static int CalculateFirstYearsTax(Vehicle vehicle)
        {
            int cost;
            int co2Emissions = vehicle.Co2Emissions;
            switch (vehicle.FuelType)
            {
                case FuelType.Petrol:
                    cost = CalculateTaxForPetrol(co2Emissions);
                    break;
                case FuelType.Diesel:
                    cost = CalculateTaxForDiesel(co2Emissions);
                    break;
                case FuelType.Electric:
                    cost = CalculateTaxForElectric(co2Emissions);
                    break;
                case FuelType.AlternativeFuel:
                    cost = CalculateTaxForAlternativeFuel(co2Emissions);
                    break;
                default:
                    throw new InvalidOperationException($"Unrecognized fuel type - {vehicle.FuelType}");
            }

            return cost;
        }

        private static int CalculateTaxForSubsequentYears(Vehicle vehicle)
        {
            int cost = 0;
            switch (vehicle.FuelType)
            {
                case FuelType.Petrol:
                case FuelType.Diesel:
                    cost = 140;
                    break;
                case FuelType.Electric:
                    cost = 0;
                    break;
                case FuelType.AlternativeFuel:
                    cost = 130;
                    break;
                default:
                    throw new InvalidOperationException($"Unrecognized fuel type - {vehicle.FuelType}");
            }

            if (vehicle.ListPrice > 40000)
            {
                cost += 310;
            }

            return cost;
        }

        private static int CalculateTaxForPetrol(int co2Emissions)
        {
            int result;
            if (co2Emissions == 0)
            {
                result = 0;
            }
            else if (co2Emissions <= 50)
            {
                result = 10;
            }
            else if (co2Emissions <= 75)
            {
                result = 25;
            }
            else if (co2Emissions <= 90)
            {
                result = 105;
            }
            else if (co2Emissions <= 100)
            {
                result = 125;
            }
            else if (co2Emissions <= 110)
            {
                result = 145;
            }
            else if (co2Emissions <= 130)
            {
                result = 165;
            }
            else if (co2Emissions <= 150)
            {
                result = 205;
            }
            else if (co2Emissions <= 170)
            {
                result = 515;
            }
            else if (co2Emissions <= 190)
            {
                result = 830;
            }
            else if (co2Emissions <= 225)
            {
                result = 1240;
            }
            else if (co2Emissions <= 255)
            {
                result = 1760;
            }
            else
            {
                result = 2070;
            }

            return result;
        }

        private static int CalculateTaxForDiesel(int co2Emissions)
        {
            int result;
            if (co2Emissions == 0)
            {
                result = 0;
            }
            else if (co2Emissions <= 50)
            {
                result = 25;
            }
            else if (co2Emissions <= 75)
            {
                result = 105;
            }
            else if (co2Emissions <= 90)
            {
                result = 125;
            }
            else if (co2Emissions <= 100)
            {
                result = 145;
            }
            else if (co2Emissions <= 110)
            {
                result = 165;
            }
            else if (co2Emissions <= 130)
            {
                result = 205;
            }
            else if (co2Emissions <= 150)
            {
                result = 515;
            }
            else if (co2Emissions <= 170)
            {
                result = 830;
            }
            else if (co2Emissions <= 190)
            {
                result = 1240;
            }
            else if (co2Emissions <= 225)
            {
                result = 1760;
            }
            else if (co2Emissions <= 255)
            {
                result = 2070;
            }
            else
            {
                result = 2070;
            }

            return result;
        }

        private static int CalculateTaxForAlternativeFuel(int co2Emissions)
        {
            int result;
            if (co2Emissions == 0)
            {
                result = 0;
            }
            else if (co2Emissions <= 50)
            {
                result = 0;
            }
            else if (co2Emissions <= 75)
            {
                result = 15;
            }
            else if (co2Emissions <= 90)
            {
                result = 95;
            }
            else if (co2Emissions <= 100)
            {
                result = 115;
            }
            else if (co2Emissions <= 110)
            {
                result = 135;
            }
            else if (co2Emissions <= 130)
            {
                result = 155;
            }
            else if (co2Emissions <= 150)
            {
                result = 195;
            }
            else if (co2Emissions <= 170)
            {
                result = 505;
            }
            else if (co2Emissions <= 190)
            {
                result = 820;
            }
            else if (co2Emissions <= 225)
            {
                result = 1230;
            }
            else if (co2Emissions <= 255)
            {
                result = 1750;
            }
            else
            {
                result = 2060;
            }

            return result;
        }

        private static int CalculateTaxForElectric(int co2Emissions)
        {
            return 0;
        }
    }
}