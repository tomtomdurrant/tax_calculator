package tax;

interface TaxCalculator{
    int calculateTax(Vehicle vehicle);
    void setCurrentYear(int year);
}
