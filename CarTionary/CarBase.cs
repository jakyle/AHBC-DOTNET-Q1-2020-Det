using System;
using System.Collections.Generic;
using System.Text;

namespace CarTionary
{
    public abstract class CarBase
    {
        public int NumberOfTires { get; set; }
        public int NumberOfDoors { get; set; }
        public double HorsePower { get; set; }
    }

    public class SUV : CarBase
    {
        public bool IsASoccerMom { get; set; }
        public double Mileage { get; set; }

    }

    public class Motorcycle : CarBase
    {
        public int AmountOfYearsReducedInYourLifeSpan { get; set; }
    }
}
