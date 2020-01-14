# Tax Calculator

This code is designed to practice approaches to CI and CD in a boot camp. It is a simplified implementation of the rules for UK vehicle tax as of 2017 (the full rules can be found here https://www.gov.uk/vehicle-tax-rate-tables).

## Preparation

It is critical that you can push changes to github.com. Check you can by logging out and logging in again. You will need to have a git client installed. In addition, there are language specific steps below.

1. Fork the project.
1. Do not clone the project using your IDE as you’ll end up opening/importing the root directory. Clone your fork from the command line by running `git clone https://github.com/YOUR_USERNAME/tax_calculator`

* [Java](exercises/java)
* [.NET](exercises/dotnet)

That’s all in terms of preparation. Please don’t read ahead, as you’ll get the most out of the boot camp if you haven’t already read the material.

## The rules for use in the exercises are summarized below:

### Story 1

##### First tax payment when you register the vehicle

|C02 g/km   |Petrol |
|-----------|-------|
|0	        |£0	    |
|1 - 50	    |£10	|
|51 - 75	|£25	|
|76 - 90	|£105	|
|91 - 100	|£125	|
|101 - 110	|£145	|
|111 - 130	|£165	|
|131 - 150	|£205	|
|151 - 170	|£515	|
|171 - 190	|£830	|
|191 - 225	|£1,240	|
|226 - 255	|£1,760	|
|Over 255	|£2,070	|

---

### Story 2

##### First tax payment when you register the vehicle

|C02 g/km   |Diesel |
|-----------|-------|
|0	        |£0     |
|1 - 50	    |£25	|
|51 - 75	|£105	|
|76 - 90	|£125	|
|91 - 100	|£145	|
|101 - 110	|£165	|
|111 - 130	|£205	|
|131 - 150	|£515	|
|151 - 170	|£830	|
|171 - 190	|£1,240	|
|191 - 225	|£1,760	|
|226 - 255	|£2,070	|
|Over 255	|£2,070	|

---

### Story 3

##### First tax payment when you register the vehicle

|C02 g/km   |Alternative Fuel|
|-----------|-------|
|0	        |£0|
|1 - 50	    |£0|
|51 - 75	|£15|
|76 - 90	|£95|
|91 - 100	|£115|
|101 - 110	|£135|
|111 - 130	|£155|
|131 - 150	|£195|
|151 - 170	|£505|
|171 - 190	|£820|
|191 - 225	|£1,230|
|226 - 255	|£1,750|
|Over 255	|£2,060|

---

### Story 4

##### Rates for second tax payment onwards

|Fuel                   |Cost    |
|-----------------------|--------|
|Petrol or Diesel       |£140    |
|Electric               |£0      |
|Alternative            |£130    |

---

### Story 5

##### Vehicles with a list price of more than £40,000

|Fuel                   |Cost    |
|-----------------------|--------|
|Petrol or Diesel       |£450    |
|Electric               |£310    |
|Alternative            |£440    |
