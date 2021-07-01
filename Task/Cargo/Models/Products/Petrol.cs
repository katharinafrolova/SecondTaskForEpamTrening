using System;
using System.Collections.Generic;
using System.Text;
using Task.Cargo.Models.ProductCategories;

namespace Task.Cargo.Models.Products
{
    public class Petrol: Liquid
    {
        public Petrol(string typeOfProduct, string nameOfProduct, double size, double weidth) : base(typeOfProduct, nameOfProduct, size, weidth)
        {

        }
    }
}
