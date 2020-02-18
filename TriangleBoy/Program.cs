using System;
using System.Collections.Generic;

namespace TriangleBoy
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangleOne = new Triangle() { SideOne = 5, SideTwo = 10, SideThree = 13 };
            var triangleThree = new Triangle() { SideOne = 7, SideTwo = 99, SideThree = 1 };
            var triangleTwo = new Triangle() { SideOne = 13, SideTwo = 42, SideThree = 8 };

            var triangles = new List<Triangle>();

            triangles.Add(triangleOne);
            triangles.Add(triangleTwo);
            triangles.Add(triangleThree);

            var triangleCollection = new TriangleCollection(triangles);

            Console.WriteLine($"Average area of all Triangles: {triangleCollection.GetAverageArea()}");
            Console.WriteLine($"Average perimeter of all Triangles: {triangleCollection.GetAveragePerimeter()}");
        }


        public static Triangle GetUserTriangle()
        {
            Console.WriteLine("Give me side One, Side Two, and Side three");

            Console.WriteLine("side one");
            var sideOne = double.Parse(Console.ReadLine());

            Console.WriteLine("side two");
            var sideTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("side three");
            var sideThree = double.Parse(Console.ReadLine());

            return new Triangle() { SideOne = sideOne, SideTwo = sideTwo, SideThree = sideThree };
        }
    }
}
