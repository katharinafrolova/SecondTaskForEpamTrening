using System;
using System.Collections.Generic;
using System.Text;
using Task.Cargo.Models.Abstract;

namespace Task.Cargo.Models.ProductCategories
{
    public class Liquid: ProductCategory
    {
        public string NameOfProduct { get; set; }

        public Liquid(string type, string name, double size, double weidth) : base(type, size , weidth)
        {
            NameOfProduct = name;
        }
    }
}
