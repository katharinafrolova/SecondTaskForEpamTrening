﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Cargo.Models.Abstract
{
    public abstract class ProductCategory
    {
        public string TypeOfProduct { get; set; }

        public double SizeOfProduct { get; set; }

        public double WeightOfProduct { get; set; }

        public ProductCategory(string type, double size, double weidth)
        {
            TypeOfProduct = type;
            SizeOfProduct = size;
            WeightOfProduct = weidth;
        }
    }
}
