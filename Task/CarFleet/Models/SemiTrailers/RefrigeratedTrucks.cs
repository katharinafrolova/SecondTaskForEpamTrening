using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class RefrigeratedTrucks: SemiTrailer
    {
        public double LeftBorderOfTheConditionsOfCarriage { get; set; }
        public double RightBorderOfTheConditionsOfCarriage { get; set; }
        
        public RefrigeratedTrucks(string nameOfCar, double amount, double leftBorderOfTemperature, double rightBorderOfTemperature) : base(amount, nameOfCar) 
        {
            if (leftBorderOfTemperature < LeftBorderOfTheConditionsOfCarriage && rightBorderOfTemperature > RightBorderOfTheConditionsOfCarriage)
                throw new ArgumentException("The storage temperature of the products does not match");
        }
        public RefrigeratedTrucks(string nameOfCar, double amount) : base(amount, nameOfCar, true) {}

        public RefrigeratedTrucks(string nameOfCar, double loadCapacity, double amount, double leftBorderOfTemperature, double rightBorderOfTemperature) : base(loadCapacity, amount, nameOfCar)
        {
            LeftBorderOfTheConditionsOfCarriage = leftBorderOfTemperature;
            RightBorderOfTheConditionsOfCarriage = rightBorderOfTemperature;
        }

    }
}
