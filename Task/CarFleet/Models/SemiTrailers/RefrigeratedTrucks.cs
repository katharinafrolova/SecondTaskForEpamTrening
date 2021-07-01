using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class RefrigeratedTrucks: SemiTrailer
    {
        public double LeftBorderOfTheConditionsOfCarriage { get; set; }
        public double RightBorderOfTheConditionsOfCarriage { get; set; }

        public RefrigeratedTrucks( double maxWeight, double addedWeight, double maxSize, double addedSize, double leftBorderOfTemperature, double rightBorderOfTemperature) : base(maxWeight, addedWeight, maxSize, addedSize)
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

        public override string ToString() => $"{base.ToString()} Left border of the conditions of carriage: {LeftBorderOfTheConditionsOfCarriage} ; Right border of the conditions of carriage {RightBorderOfTheConditionsOfCarriage} ;";

        public override int GetHashCode()
        {
            int hashCode = 1909959431;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + LeftBorderOfTheConditionsOfCarriage.GetHashCode();
            hashCode = hashCode * -1521134295 + RightBorderOfTheConditionsOfCarriage.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj) => obj is RefrigeratedTrucks refrigeratedTrucks && base.Equals(obj) && LeftBorderOfTheConditionsOfCarriage == refrigeratedTrucks.LeftBorderOfTheConditionsOfCarriage && RightBorderOfTheConditionsOfCarriage == refrigeratedTrucks.RightBorderOfTheConditionsOfCarriage;


    }
}
