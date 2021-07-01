using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models
{
    public abstract class SemiTrailer
    {
        /// <summary>
        ///  Auto property that describes the maximum size of goods allowed in semi-trailers
        /// </summary>
        public double MaxSize { get; set; }

        /// <summary>
        ///  Auto property that describes the maximum weight of goods allowed in semi-trailers
        /// </summary>
        public double MaxWeight { get; set; }

        /// <summary>
        ///  Auto property that describes the size of goods occupied in semi-trailers
        /// </summary>
        public double LoadedSize { get; set; }

        /// <summary>
        ///  Auto property that describes the size of goods occupied in semi-trailers
        /// </summary>
        public double LoadedWeight { get; set; }

        public SemiTrailer(double maxWeight, double addedWeight, double maxSize, double addedSize)
        {
            MaxSize = maxSize;
            MaxWeight = maxWeight;
            LoadedSize = 0;
            LoadedWeight = 0;
            if (addedSize > FreePlaceOfSize())
            {
                throw new ArgumentException("The size exceeds the load size");
            }
            if (addedWeight > FreePlaceOfWeight())
            {
                throw new ArgumentException("The weight exceeds the load weight");
            }
            LoadedSize = addedSize;
            LoadedWeight = addedWeight;
        }

        public double FreePlaceOfSize() => MaxSize - LoadedSize;

        public double FreePlaceOfWeight() => MaxWeight - LoadedWeight;

        public bool LoadingOfSemiTrailers(double loadingOfSize, double loadingOfWeight)
        {
            bool result = true;
            if (loadingOfSize > FreePlaceOfSize())
            {
                result = false;
                throw new ArgumentException("The size exceeds the load size");
            }
            if (loadingOfWeight > FreePlaceOfWeight())
            {
                result = false;
                throw new ArgumentException("The weight exceeds the load weight");
            }
            LoadedSize = LoadedSize + loadingOfSize;
            LoadedWeight = LoadedWeight + loadingOfWeight;
            return result;
        }

        public bool UnloadingOfSemiTrailers(double uploadingOfSize, double uploadingOfWeight)
        {
            bool result = true;
            if (uploadingOfSize > LoadedSize)
            {
                result = false;
                throw new ArgumentException("Еhe size of unloaded products exceeds the existing size");
            }
            if (uploadingOfWeight > LoadedWeight)
            {
                result = false;
                throw new ArgumentException("Еhe weight of unloaded products exceeds the existing weight");
            }
            LoadedSize = LoadedSize - uploadingOfSize;
            LoadedWeight = LoadedWeight - uploadingOfWeight;
            return result;
        }


        public override string ToString() => $"{base.ToString()} Max weight: {MaxWeight} ; Max size {MaxSize} ; Loaded size {LoadedSize} ;  Loaded weight {LoadedWeight} ";
        
        public override int GetHashCode()
        {
            int hashCode = 1909959431;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxWeight.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxSize.GetHashCode();
            hashCode = hashCode * -1521134295 + LoadedSize.GetHashCode();
            hashCode = hashCode * -1521134295 + LoadedWeight.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj) => obj is SemiTrailer semiTrailer && base.Equals(obj) && MaxWeight == semiTrailer.MaxWeight && MaxSize == semiTrailer.MaxSize && LoadedSize == semiTrailer.LoadedSize && LoadedWeight == semiTrailer.LoadedWeight;


    }
}
