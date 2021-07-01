using System;
using System.Collections.Generic;
using System.Text;
using Task.CarFleet.Models;

namespace Task.CarFleet.Models
{
    public class AboutCarFleet
    {
        public List<TruckTractor> ListOfTruckTractors { get; set; }
        public List<SemiTrailer> ListOfSemiTrailers { get; set; }


        public AboutCarFleet(List<TruckTractor> listOfTruckTractors, List<SemiTrailer> listOfSemiTrailers)
        {
            ListOfTruckTractors = listOfTruckTractors;
            ListOfSemiTrailers = listOfSemiTrailers;
        }
    }
}
