using System;
using System.Collections.Generic;
using System.Text;
using Task.CarFleet.Models;

namespace Task.CarFleetLogistics.Models
{
    public class CouplingOfTruckTractorAndSemiTrailer
    {
        public SemiTrailer SemiTrailerCar { get; set; }
        public TruckTractor TruckTractorCar { get; set; }

        public CouplingOfTruckTractorAndSemiTrailer(SemiTrailer semiTrailerCar, TruckTractor truckTractorCar)
        {
            SemiTrailerCar = semiTrailerCar;
            TruckTractorCar = truckTractorCar;
        }

        public double CalculateOfPatrol()
        {
            double countOfPatrol = 0;
            countOfPatrol = TruckTractorCar.WeightOfTruckTractor + SemiTrailerCar.MaxWeight;
            return countOfPatrol;
        }

        
    }
}
