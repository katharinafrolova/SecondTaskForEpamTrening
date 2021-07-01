using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Cargo.Models.Abstract
{
    public abstract class ProductCategory
    {
        public string TypeOfProduct { get; set; }

        public ProductCategory(string type)
        {
            TypeOfProduct = type;
        }
    }
}
