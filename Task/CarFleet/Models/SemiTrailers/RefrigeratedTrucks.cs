using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class RefrigeratedTrucks: SemiTrailer
    {
        public double LeftBorderOfTheConditionsOfCarriage { get; set; }
        public double RightBorderOfTheConditionsOfCarriage { get; set; }

        public RefrigeratedTrucks(string nameOfCar, double maxWeight, double addedWeight, double maxSize, double addedSize, double leftBorderOfTemperature, double rightBorderOfTemperature) : base(maxWeight, addedWeight, maxSize, addedSize, nameOfCar)
        {
            LeftBorderOfTheConditionsOfCarriage = leftBorderOfTemperature;
            RightBorderOfTheConditionsOfCarriage = rightBorderOfTemperature;
        }

        public bool LoadingOfSemiTrailers(double addedSize, double addedWeight, double leftBorderOfTemperature, double rightBorderOfTemperature)
        {
            bool result = true;
            if (leftBorderOfTemperature < LeftBorderOfTheConditionsOfCarriage && rightBorderOfTemperature > RightBorderOfTheConditionsOfCarriage)
            {
                result = false;
                throw new ArgumentException("The storage temperature of the products does not match");
            }
            if (!this.LoadingOfSemiTrailers(addedSize, addedWeight))
                result = false;
            return result;
        }

    }
}
