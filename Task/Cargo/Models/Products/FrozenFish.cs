using System;
using System.Collections.Generic;
using System.Text;
using Task.Cargo.Models.ProductCategories;

namespace Task.Cargo.Models.Products
{
    public class FrozenFish : ProductWithTemperatureStorageCondition
    {
        public FrozenFish(string typeOfProduct, double leftBorderOfTemperature, double rightBorderOfTemperature, double size, double weidth) : base(typeOfProduct, leftBorderOfTemperature, rightBorderOfTemperature, size, weidth)
        {

        }
    }
}
