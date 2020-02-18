using System;

namespace enumies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey user, what kind of car do you want? please enter a number between 1 - 6.");
            Console.WriteLine("[1]. Truck");
            Console.WriteLine("[2]. Suv");
            Console.WriteLine("[3]. Motorcycle");
            Console.WriteLine("[4]. Bus");
            Console.WriteLine("[5]. Coupe");
            Console.WriteLine("[6]. Rickshaw");

            string userInput = Console.ReadLine();

            if (Enum.TryParse<CarType>(userInput, out CarType cartype))
            {
                switch (cartype)
                {
                    case CarType.Truck:
                        car = new Car(CarType.Truck);
                        break;
                    case CarType.Suv:
                        break;
                    case CarType.Motorcycle:
                        break;
                    case CarType.Bus:
                        break;
                    case CarType.Coupe:
                        break;
                    case CarType.Rickshaw:
                        break;
                    default:
                        break;
                }
            }



            var name = "James";

            name.Equals("james", StringComparison.OrdinalIgnoreCase);


            var car = new Car();
            car.Type = CarType.Bus;

            car.Mileage = 10000;

            car.Vroom();
        }
    }
}
