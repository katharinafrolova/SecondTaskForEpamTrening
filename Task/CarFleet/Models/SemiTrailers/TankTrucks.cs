using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class TankTrucks: SemiTrailer
    {
        public string TypeOfLiquid { get; set; }
        public string NameOfLiquid { get; set; }
        public TankTrucks(string nameOfCar, double amount, string type, string name) : base(amount, nameOfCar) 
        {
            if (type != TypeOfLiquid)
                throw new ArgumentException("You can't upload this type of product");
            if (name != NameOfLiquid)
                throw new ArgumentException("You can't upload this product");
        }
        public TankTrucks(string nameOfCar, double amount) : base(amount, nameOfCar, true) { }

        public TankTrucks(string nameOfCar, double loadCapacity, double amount, string type, string name) : base(loadCapacity, amount, nameOfCar)
        {
            TypeOfLiquid = type;
            NameOfLiquid = name;
        }

    }
}
