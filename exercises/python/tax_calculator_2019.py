class TaxCalculator2019:

    def calculate_tax(self, vehicle):

        cost = None
        co2_emissions = vehicle.getco2_emissions()

        if vehicle.fuel_type is "PETROL":
            cost = self.calculate_tax_for_petrol(co2_emissions)
        elif vehicle.fuel_type is "DIESEL":
            cost = self.calculate_tax_for_diesel(co2_emissions)
        elif vehicle.fuel_type is "ALTERNATIVE_FUEL":
            cost = self.calculate_tax_for_alternative_fuel(co2_emissions)
        elif vehicle.fuel_type is "ELECTRIC":
            cost = self.calculate_tax_for_electric(co2_emissions)
        return cost

    def calculate_tax_for_petrol(self, co2_emissions):

        if co2_emissions == 0:
            cost = 0
        elif co2_emissions <= 50:
            cost = 10
        elif co2_emissions <= 75:
            cost = 25
        elif co2_emissions <= 90:
            cost = 105
        elif co2_emissions <= 100:
            cost = 125
        elif co2_emissions <= 110:
            cost = 145
        elif co2_emissions <= 130:
            cost = 165
        elif co2_emissions <= 150:
            cost = 205
        elif co2_emissions <= 170:
            cost = 515
        elif co2_emissions <= 190:
            cost = 830
        elif co2_emissions <= 225:
            cost = 1240
        elif co2_emissions <= 255:
            cost = 1760
        else:
            cost = 2070

        return cost

    def calculate_tax_for_diesel(self, co2_emissions):

        if co2_emissions == 0:
            cost = 0
        elif co2_emissions <= 50:
            cost = 25
        elif co2_emissions <= 75:
            cost = 105
        elif co2_emissions <= 90:
            cost = 125
        elif co2_emissions <= 100:
            cost = 145
        elif co2_emissions <= 110:
            cost = 165
        elif co2_emissions <= 130:
            cost = 205
        elif co2_emissions <= 150:
            cost = 515
        elif co2_emissions <= 170:
            cost = 830
        elif co2_emissions <= 190:
            cost = 1240
        elif co2_emissions <= 225:
            cost = 1760
        elif co2_emissions <= 255:
            cost = 2070
        else:
            cost = 2070
        return cost

    def calculate_tax_for_alternative_fuel(self, co2_emissions):

        if co2_emissions == 0:
            cost = 0
        elif co2_emissions <= 50:
            cost = 0
        elif co2_emissions <= 75:
            cost = 15
        elif co2_emissions <= 90:
            cost = 95
        elif co2_emissions <= 100:
            cost = 115
        elif co2_emissions <= 110:
            cost = 135
        elif co2_emissions <= 130:
            cost = 155
        elif co2_emissions <= 150:
            cost = 195
        elif co2_emissions <= 170:
            cost = 505
        elif co2_emissions <= 190:
            cost = 820
        elif co2_emissions <= 225:
            cost = 1230
        elif co2_emissions <= 255:
            cost = 1750
        else:
            cost = 2060
        return cost

    def calculate_tax_for_electric(self, co2_emissions):
        return 0


