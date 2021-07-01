using System;
using System.Collections.Generic;
using System.Text;

namespace Task.CarFleet.Models
{
    public class TruckTractor
    {
        public double MaxSize { get; set; }

        public double WeightOfTruckTractor { get; set; }
        
        public TruckTractor(double maxSize, double weightOfTruckTractor)
        {
            MaxSize = maxSize;
            WeightOfTruckTractor = weightOfTruckTractor;
        }

    }
}
