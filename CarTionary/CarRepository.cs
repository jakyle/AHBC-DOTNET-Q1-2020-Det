using System;
using System.Collections.Generic;
using System.Text;

namespace CarTionary
{
    class CarRepository
    {

        public static Dictionary<string, List<CarBase>> GetCars()
        {
            var carTionary = new Dictionary<string, List<CarBase>>();

            var suvs = new List<CarBase>();

            suvs.Add(new SUV() { IsASoccerMom = true});
            suvs.Add(new SUV() { IsASoccerMom = false});

            var motorCycles = new List<CarBase>();
            


            var motorcycle = new Motorcycle() { AmountOfYearsReducedInYourLifeSpan = 22 };


            motorCycles.Add(new Motorcycle() { AmountOfYearsReducedInYourLifeSpan = 50});
            motorCycles.Add(new Motorcycle() { AmountOfYearsReducedInYourLifeSpan = 10});
            motorCycles.Add(new Motorcycle() { AmountOfYearsReducedInYourLifeSpan = 60});

            carTionary["SUV"] = suvs;
            carTionary["Motorcycles"] = motorCycles;

            return carTionary;
        }
    }
}
