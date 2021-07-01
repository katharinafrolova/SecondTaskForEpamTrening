using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Cargo.Models.ProductCategory
{
    public class Liquid
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Liquid(string type, string name) 
        {
            Type = type;
            Name = name;
        }
    }
}
