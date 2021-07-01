using System;
using System.Collections.Generic;
using System.Text;
using Task.Cargo.Models.Abstract;

namespace Task.Cargo.Models.ProductCategories
{
    public class ProductWithoutSomeStorageConditions: ProductCategory
    {
        public ProductWithoutSomeStorageConditions(string type, double size, double weidth) : base(type, size, weidth)
        {}
    }
}
