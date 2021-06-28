using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models
{
    public abstract class SemiTrailer: Car
    {
        public double LoadCapacity { get; set; }
        public double LoadedQuantity { get; set; }

        public SemiTrailer(double amount, string name) : base(name, true)
        {
            if (amount > FreePlace())
            {
                throw new ArgumentException("The weight exceeds the load capacity");
            }
            LoadedQuantity = LoadedQuantity + amount;
        }
        public SemiTrailer(double amount, string name, bool flag) : base(name, true)
        {
            if (amount > LoadedQuantity)
            {
                throw new ArgumentException("Еhe number of unloaded products exceeds the existing number");
            }
            LoadedQuantity = LoadedQuantity - amount;
        }

        public SemiTrailer(double loadCapacity, double amount, string name) : base(name)
        {
            LoadCapacity = loadCapacity;
            LoadedQuantity = 0;
            if (amount > FreePlace())
            {
                throw new ArgumentException("The weight exceeds the load capacity");
            }
            LoadedQuantity = amount;
        }

        public double FreePlace() => LoadCapacity - LoadedQuantity;

    }
}
