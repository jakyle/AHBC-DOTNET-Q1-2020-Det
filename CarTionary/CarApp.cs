using System;
using System.Collections.Generic;
using System.Text;

namespace CarTionary
{
    public class CarApp
    {
        private Dictionary<string, List<CarBase>> _cartionary = CarRepository.GetCars();
        
        public void Run()
        {
            string userInput = GetUserInput();

            if (userInput.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                PrintCarBaseProperties("SUV");

            }

            if (userInput.Equals("m", StringComparison.OrdinalIgnoreCase))
            {
                PrintCarBaseProperties("Motorcycle");

            }

        }

        private  void PrintCarBaseProperties(string key)
        {
                if (!_cartionary.TryGetValue(key, out var carBaseList))
                {
                    Console.WriteLine($"sorry person, no {key}s");
                }
                else
                {
                    foreach (var carBase in carBaseList)
                    {
                        MatchPrintCarBase(carBase);
                    }
                }
        }

        private static string GetUserInput()
        {
            Console.WriteLine("Select either [S]uv or [M]otorcycle (please  select either M or S)");
            var userInput = Console.ReadLine();
            return userInput;
        }

        private void MatchPrintCarBase(CarBase carBase)
        {
            switch (carBase)
            {
                case Motorcycle motorCycle:
                    Console.WriteLine(motorCycle.AmountOfYearsReducedInYourLifeSpan);
                    break;
                case SUV suv:
                    Console.WriteLine(suv.IsASoccerMom);
                    break;

                default: throw new ArgumentOutOfRangeException(nameof(carBase));
            }
        }
    }
}
