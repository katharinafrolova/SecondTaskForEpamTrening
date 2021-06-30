using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class AwningSemiTrailers: SemiTrailer
    {
        public string  TypeOfProduct { get; set; }

        public AwningSemiTrailers(string nameOfCar, double maxWeight, double addedWeight, double maxSize, double addedSize, string type) : base(maxWeight, addedWeight, maxSize, addedSize, nameOfCar)
        {
            TypeOfProduct = type;
        }
        

        public bool LoadingOfSemiTrailers(double addedSize, double addedWeight, string addedType, string addedName)
        {
            bool result = true;
            if (addedType != TypeOfProduct)
            {
                result = false;
                throw new ArgumentException("You can't upload this type of product");
            }
            if (!this.LoadingOfSemiTrailers(addedSize, addedWeight))
                result = false;
            return result;
        }
    }
}
