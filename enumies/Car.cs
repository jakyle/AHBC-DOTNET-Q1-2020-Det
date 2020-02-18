using System;
using System.Collections.Generic;
using System.Text;

namespace enumies
{
    public class Car
    {
        public Car(CarType type)
        {
            Type = type;
        }

        public Car() { }

        public int Mileage { get; set; }
        public CarType Type { get; set; }

        public void Vroom()
        {
            Console.WriteLine("Vroom vroom");
        }


    }
}
