package tax;

// DO NOT MAKE ANY CHANGES TO THIS CLASS - IT IS JUST HERE TO KEEP THE TESTS HAPPY TO BEGIN WITH
// DON'T BE LAZY - WRITE YOUR OWN NEW TAXCALCULATOR CLASS
@Deprecated
public final class DummyTaxCalculator implements TaxCalculator {
    @Override
    public int calculateTax(Vehicle vehicle) {
        return -1;
    }

    @Override
    public void setCurrentYear(int year) {
        // DO NOTHING - this is just a dummy implementation
    }
}
