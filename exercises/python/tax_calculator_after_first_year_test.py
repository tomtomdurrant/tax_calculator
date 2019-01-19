import unittest
from dummy_tax_calculator import  DummyTaxCalculator

class TaxCalculatorAfterFirstYearTest(unittest.TestCase):
	def setUp(self):
		self.tax_calculator = DummyTaxCalculator()
		self.FIRST_OF_APRIL_2017 = datetime.date(2017, 4, 1)


	def test_subsequent_years_tax_for(self):
		vehicle = Vehicle(206, "PETROL", FIRST_OF_APRIL_2017, 20000)
		self.assertEqual(140, tax_calculator.calculate_tax(vehicle))

	def test_subsequent_years_tax_for_electric(self):
		vehicle = Vehicle(206, "ELECTRIC", FIRST_OF_APRIL_2017, 20000)
		self.assertEqual(0, tax_calculator.calculate_tax(vehicle))

	def test_subsequent_years_tax_for_alternative_fuel(self):
		vehicle = Vehicle(206, "ALTERNATIVE_FUEL", FIRST_OF_APRIL_2017, 20000)
		self.assertEqual(130, tax_calculator.calculate_tax(vehicle))
