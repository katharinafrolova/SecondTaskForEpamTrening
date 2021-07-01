using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Cargo.Models.ProductCategory
{
    public class ProductWithoutSomeStorageConditions
    {
        public string TypeOfProduct { get; set; }

        public ProductWithoutSomeStorageConditions(string type) 
        {
            TypeOfProduct = type;
        }
    }
}
