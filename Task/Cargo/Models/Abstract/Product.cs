using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Cargo.Models.Abstract
{
    public abstract class Product
    {
        public double SizeOfProduct { get; set; }

        public double WeightOfProduct { get; set; }

        public Product(double size, double weight)
        {
            SizeOfProduct = size;
            WeightOfProduct = weight;
        }
    }
}
