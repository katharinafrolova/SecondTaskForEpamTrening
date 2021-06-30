using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class TankTrucks: SemiTrailer
    {
        public string TypeOfLiquid { get; set; }
        public string NameOfLiquid { get; set; }
        public TankTrucks(string nameOfCar, double maxWeight, double addedWeight, double maxSize, double addedSize, string type, string name) : base(maxWeight, addedWeight, maxSize, addedSize, nameOfCar)
        {
            TypeOfLiquid = type;
            NameOfLiquid = name;
        }

        public bool LoadingOfSemiTrailers(double addedSize, double addedWeight, string addedType, string addedName)
        {
            bool result = true;
            if (addedType != TypeOfLiquid)
            {
                result = false;
                throw new ArgumentException("You can't upload this type of product");
            }
            if (addedName != NameOfLiquid)
            {
                result = false;
                throw new ArgumentException("You can't upload this product");
            }
            if (!this.LoadingOfSemiTrailers(addedSize, addedWeight))
                result = false;
            return result;
        }
        

       

    }
}
