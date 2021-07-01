using System;
using System.Collections.Generic;
using System.Text;
using Task.Cargo.Models.ProductCategories;

namespace Task.Cargo.Models.Products
{
    public class WashingPowder: ProductWithoutSomeStorageConditions
    {
        public WashingPowder(string typeOfProduct, double size, double weidth) : base(typeOfProduct, size, weidth)
        {

        }
    }
}
