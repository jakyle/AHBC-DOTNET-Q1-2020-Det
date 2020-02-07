using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Animal
    {
        public Animal(int age, double weight, string name, bool isAlive)
        {
            Age = age;
            Weight = weight;
            Name = name;
            IsAlive = isAlive;
        }

        protected int Age { get; set; }
        protected double Weight { get; set; }
        public string Name { get; set; }
        public virtual bool IsAlive { get; set; } = false;

        public virtual string MakeNoise()
        {
            return "I HAVE NO REAL IDENTITY HELP ME!!!";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}


