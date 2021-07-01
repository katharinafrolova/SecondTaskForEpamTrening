using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Cargo.Models.ProductCategory
{
    public class ProductWithTemperatureStorageCondition
    {
        public double LeftBorderOfTheConditionsOfCarriage { get; set; }
        public double RightBorderOfTheConditionsOfCarriage { get; set; }

        public ProductWithTemperatureStorageCondition( double leftBorderOfTemperature, double rightBorderOfTemperature) 
        {
            LeftBorderOfTheConditionsOfCarriage = leftBorderOfTemperature;
            RightBorderOfTheConditionsOfCarriage = rightBorderOfTemperature;
        }
    }
}
