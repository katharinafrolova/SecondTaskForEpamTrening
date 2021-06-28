using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class AwningSemiTrailers: SemiTrailer
    {
        public string  TypeOfProduct { get; set; }
        public AwningSemiTrailers(string nameOfCar, double amount, string type) : base(amount, nameOfCar) 
        {
            if (type != TypeOfProduct)
                throw new ArgumentException("You can't upload this type of product");
        }
        public AwningSemiTrailers(string nameOfCar, double amount) : base(amount, nameOfCar, true) { }


        public AwningSemiTrailers(string nameOfCar, double loadCapacity, double amount, string type ) : base(loadCapacity, amount, nameOfCar)
        {
            TypeOfProduct = type;
        }
    }
}
