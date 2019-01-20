namespace TaxCalculator
{
    public class TaxCalculator2019 : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            int result = 0;
            int co2Emissions = vehicle.Co2Emissions;

            if (co2Emissions == 0)
            {
                result = 0;
            } else if (co2Emissions <= 50)
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
    }
}