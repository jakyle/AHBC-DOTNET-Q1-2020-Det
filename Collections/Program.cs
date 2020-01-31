using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // Collections

            // List

            List<string> names = new List<string>() 
            {
                "James",
                "Darion",
                "DarionJames",
                "Larion"
            };

            names.Add("Shmarion");
            names.Add("Blarion");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            names.RemoveAt(2);


            // Adds an element at specific index
            names.Insert(2, "JamesShmarion");

            names.Clear();

            bool doesContainName = names.Contains("JamesShmarion");



            // reference type vs value types
            int number = 3;
            int number2 = number;

            

            number = 100;

            List<string> refExample = new List<string>();

            refExample.Add("James");

            List<string> refExampleTwo = refExample;


            // more list things

            string[] namesArray = names.ToArray();


            // DONT EVER DO THIS

            string name = null;

            string upperCaseName = name.ToUpper();
        }
    }
}
