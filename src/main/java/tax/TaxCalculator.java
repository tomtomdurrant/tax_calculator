package tax;

import java.time.LocalDate;

abstract class TaxCalculator{
    private int year;

    abstract int calculateTax(Vehicle vehicle);

    TaxCalculator(){
        this(LocalDate.now().getYear());
    }

    TaxCalculator(int year){
        this.year = year;
    }
}
