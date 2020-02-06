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

            Console.ReadLine();


            // Lab 2 exmple

            var app = new RoomApp();
            app.Run();

        }
    }
}
