using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WinterHat winterHat = new WinterHat();

            winterHat.Color = "black";
            winterHat.Size = 2;

            string color = winterHat.Color;

            // string thrownHat = winterHat.ThrowAHat();

            Console.WriteLine(winterHat.Color);
            Console.WriteLine(winterHat.Size);

            Console.ReadLine();
        }
    }
}
