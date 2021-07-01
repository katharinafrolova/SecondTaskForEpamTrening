using System;
using System.Collections.Generic;
using System.Text;
using Task.Cargo.Models.Abstract;

namespace Task.Cargo.Models.ProductCategories
{
    public class ProductWithTemperatureStorageCondition: ProductCategory
    {
        public double LeftBorderOfTheConditionsOfCarriage { get; set; }
        public double RightBorderOfTheConditionsOfCarriage { get; set; }

        public ProductWithTemperatureStorageCondition(string type, double leftBorderOfTemperature, double rightBorderOfTemperature, double size, double weidth) : base (type, size, weidth) 
        {
            LeftBorderOfTheConditionsOfCarriage = leftBorderOfTemperature;
            RightBorderOfTheConditionsOfCarriage = rightBorderOfTemperature;
        }
    }
}
