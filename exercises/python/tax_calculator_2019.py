from tax_calculator import TaxCalculator


class TaxCalculator2019(TaxCalculator):

    def calculate_tax(self, vehicle):
        result = None
        co2_emissions = vehicle.getco2_emissions()

        if co2_emissions == 0:
            result = 0
        elif co2_emissions <= 50:
            result = 10
        elif co2_emissions <= 75:
            result = 25
        elif co2_emissions <= 90:
            result = 105
        elif co2_emissions <= 100:
            result = 125
        elif co2_emissions <= 110:
            result = 145
        elif co2_emissions <= 130:
            result = 165
        elif co2_emissions <= 150:
            result = 205
        elif co2_emissions <= 170:
            result = 515
        elif co2_emissions <= 190:
            result = 830
        elif co2_emissions <= 225:
            result = 1240
        elif co2_emissions <= 255:
            result = 1760
        else:
            result = 2070

        return result
