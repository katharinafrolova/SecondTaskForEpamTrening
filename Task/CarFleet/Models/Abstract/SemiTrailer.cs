using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models
{
    public abstract class SemiTrailer: Car
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

        public SemiTrailer(double maxWeight, double addedWeight, double maxSize, double addedSize, string name) : base(name)
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

        //public SemiTrailer(double weight, double addedSize, string name) : base(name, true)
        //{
        //    if (addedSize > FreePlaceOfSize())
        //    {
        //        throw new ArgumentException("The size exceeds the load size");
        //    }
        //    if(weight >FreePlaceOfWeight())
        //    {
        //        throw new ArgumentException("The weight exceeds the load weight");
        //    }
        //    LoadedSize = LoadedSize + addedSize;
        //}
        //public SemiTrailer(double weight, double addedSize, string name, bool flag) : base(name, true)
        //{
        //    if (addedSize > LoadedSize)
        //    {
        //        throw new ArgumentException("Еhe number of unloaded products exceeds the existing number");
        //    }
        //    LoadedSize = LoadedSize - addedSize;
        //}

       
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

    }
}
