namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            var emissions = vehicle.Co2Emissions;
            if (emissions == 0)
            {
                return 0;
            }

            if (emissions <= 50)
            {
                return 10;
            }

            if (emissions <= 75)
            {
                return 25;
            }

            if (emissions <= 90)
            {
                return 105;
            }

            if (emissions <= 100)
            {
                return 125;
            }

            if (vehicle.Co2Emissions <= 110)
            {
                return 145;
            }

            if (emissions <= 130)
            {
                return 165;
            }

            if (emissions <= 150)
            {
                return 205;
            }

            if (emissions <= 170)
            {
                return 515;
            }

            if (emissions <= 190)
            {
                return 830;
            }

            if (emissions <= 225)
            {
                return 1240;
            }

            if (emissions <=255)
            {
                return 1760;
            }

            return 2070;
        }
    }
}