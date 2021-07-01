using System;
using System.Collections.Generic;
using System.Text;
using Task.Cargo.Models.Abstract;
using Task.Cargo.Models.ProductCategories;

namespace Task.Cargo.Models.Products
{
    public class Apple: ProductWithoutSomeStorageConditions
    {
        public Apple(string typeOfProduct, double size, double weidth): base(typeOfProduct, size, weidth)
        {

        }
    }
}
