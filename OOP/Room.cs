using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Room
    {
        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return this.Length * this.Width;
        }

        public double GetVolume()
        {
            return GetArea() * Height;
        }
    }
}
