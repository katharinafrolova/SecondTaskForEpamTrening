using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models.SemiTrailers
{
    public class TankTrucks: SemiTrailer
    {
        public string TypeOfLiquid { get; set; }
        public string NameOfLiquid { get; set; }
        public TankTrucks( double maxWeight, double addedWeight, double maxSize, double addedSize, string type, string name) : base(maxWeight, addedWeight, maxSize, addedSize)
        {
            TypeOfLiquid = type;
            NameOfLiquid = name;
        }

        public bool LoadingOfSemiTrailers(double addedSize, double addedWeight, string addedType, string addedName)
        {
            bool result = true;
            if (addedType != TypeOfLiquid)
            {
                result = false;
                throw new ArgumentException("You can't upload this type of product");
            }
            if (addedName != NameOfLiquid)
            {
                result = false;
                throw new ArgumentException("You can't upload this product");
            }
            if (!this.LoadingOfSemiTrailers(addedSize, addedWeight))
                result = false;
            return result;
        }


        public override string ToString() => $"{base.ToString()} Type of liquid: {TypeOfLiquid} ; Name of liquid {NameOfLiquid} ;";

        public override int GetHashCode()
        {
            int hashCode = 1909959431;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + TypeOfLiquid.GetHashCode();
            hashCode = hashCode * -1521134295 + NameOfLiquid.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj) => obj is TankTrucks tankTrucks && base.Equals(obj) && TypeOfLiquid == tankTrucks.TypeOfLiquid && NameOfLiquid == tankTrucks.NameOfLiquid;


    }
}
