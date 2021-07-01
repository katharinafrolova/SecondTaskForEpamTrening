using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class AwningSemiTrailers: SemiTrailer
    {
        public string  TypeOfProduct { get; set; }

        public AwningSemiTrailers( double maxWeight, double addedWeight, double maxSize, double addedSize, string type) : base(maxWeight, addedWeight, maxSize, addedSize)
        {
            TypeOfProduct = type;
        }
        

        public bool LoadingOfSemiTrailers(double addedSize, double addedWeight, string addedType, string addedName)
        {
            bool result = true;
            if (addedType != TypeOfProduct)
            {
                result = false;
                throw new ArgumentException("You can't upload this type of product");
            }
            if (!this.LoadingOfSemiTrailers(addedSize, addedWeight))
                result = false;
            return result;
        }

        public override string ToString() => $"{base.ToString()} Type of product: {TypeOfProduct} ; ";

        public override int GetHashCode()
        {
            int hashCode = 1909959431;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + TypeOfProduct.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj) => obj is AwningSemiTrailers awningSemiTrailers && base.Equals(obj) && TypeOfProduct == awningSemiTrailers.TypeOfProduct;

    }
}
