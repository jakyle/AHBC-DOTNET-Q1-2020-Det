using System;
using System.Collections.Generic;
using System.Text;

namespace CarTionary
{
    public static class CarApp
    {
        public static void Run()
        {

            Console.WriteLine("Select either [S]uv or [M]otorcycle (please  select either M or S)");
            var userInput = Console.ReadLine();
            var carRepository = new CarRepository();

            var carTionary = carRepository.GetCars();

            if (userInput.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                
            }
        }
    }
}
