package tax;

import java.time.LocalDate;

class Vehicle {
    private final int co2Emissions;
    private final FuelType fuelType;
    private LocalDate dateOfFirstRegistration;
    private int listPrice;

    Vehicle(int co2Emissions, FuelType fuelType, LocalDate dateOfFirstRegistration, int listPrice) {
        this.co2Emissions = co2Emissions;
        this.fuelType = fuelType;
        this.dateOfFirstRegistration = dateOfFirstRegistration;
        this.listPrice = listPrice;
    }

    public int getCo2Emissions() {
        return co2Emissions;
    }

    public FuelType getFuelType() {
        return fuelType;
    }

    public LocalDate getDateOfFirstRegistration() {
        return dateOfFirstRegistration;
    }

    public void setDateOfFirstRegistration(LocalDate dateOfFirstRegistration) {
        this.dateOfFirstRegistration = dateOfFirstRegistration;
    }
}
