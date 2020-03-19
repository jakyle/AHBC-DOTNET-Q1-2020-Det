using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleBoy
{
    public class Triangle
    {
        public double SideOne { get; set; }
        public double SideTwo { get; set; }
        public double SideThree { get; set; }

        public double GetArea()
        {
            return Math.Sqrt(GetPerimiter() / 2);
        }

        public double GetPerimiter()
        {
            return SideOne + SideTwo + SideThree;
        }

    }
}
