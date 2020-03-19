using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!", "sup");

            WinterHat winterHat = new WinterHat("black", 2);

            WinterHat emptyWinterHat = new WinterHat();

            emptyWinterHat.Color = "White";
           
            string color = winterHat.Color;

            // string thrownHat = winterHat.ThrowAHat();

            Console.WriteLine(winterHat.Color);
            Console.WriteLine(winterHat.Size);

           // Console.ReadLine();


            // Lab 2 exmple

            string name;

            var app = new RoomApp();
            // app.Run();


            // Inheritance 

            var animal = new Animal(2, 23, "Jay", true);

            var dog = new Dog(2, 5.2, "Phillip", true, "Beagle", "Magenta", true);
            var otherDog = new Dog(1, 3.2, "Jeffery", true, "Beagle", "Magenta", true);



            var puppers = new Puppers(1, 1, "Baby boy", true, "poodle", "white", true);
            Console.WriteLine(puppers.MakeNoise());


        }
    }
}
