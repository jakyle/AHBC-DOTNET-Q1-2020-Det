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
            List<int> numers = new List<int>();

            refExample.Add("James");

            List<string> refExampleTwo = refExample;


            // more list things

            string[] namesArray = names.ToArray();


            // DONT EVER DO THIS

            string name = null;

            // string upperCaseName = name.ToUpper();

            WriteToConsole<int, string>(22, "sup");
            WriteToConsole<bool, List<string>>(true, new List<string>());

            List<List<List<List<List<List<List<List<string>>>>>>>> insanity = new List<List<List<List<List<List<List<List<string>>>>>>>>();

            // Hash Set

            HashSet<string> uniqueNames = new HashSet<string>();

            string nameOne = "Darion";
            string nameTwo = "Darion";
            string nameThree = "Jamesrion";

            uniqueNames.Add(nameOne);
            uniqueNames.Add(nameTwo);
            uniqueNames.Add(nameThree);

            foreach (string uniqueName in uniqueNames)
            {
                Console.WriteLine(uniqueName);
            }

            // Dicionary 

            List<string> dayTimeCSharpStudents = new List<string>()
            {
                "Larry",
                "Barry",
                "Goldmans Sacks"
            };

            List<string> afterHoursCSharpStudents = new List<string>()
            {
                "Joe",
                "Moe",
                "Floe"
            };

            List<string> afterHoursCHarpStudents = new List<string>()
            {
                "Alejandra",
                "Jonathan",
                "Tim"
            };

            int superDopeAssVariable = 2;

            string thisISADifferentDopeAssVariable = nameof(superDopeAssVariable);


            Dictionary<string, List<string>> grandCircusClasses = new Dictionary<string, List<string>>();

            grandCircusClasses[nameof(dayTimeCSharpStudents)] = dayTimeCSharpStudents;
            grandCircusClasses[nameof(afterHoursCSharpStudents)] = afterHoursCHarpStudents;
            grandCircusClasses[nameof(afterHoursCHarpStudents)] = afterHoursCHarpStudents;

            List<string> someStudentsIGuess = grandCircusClasses[nameof(afterHoursCHarpStudents)];


            // more dictionary stuff

            Dictionary<string, int> staffAge = new Dictionary<string, int>();

            staffAge["James"] = 31;
            staffAge["Darion"] = 30;
            staffAge["Drew"] = 28;

            if (IsCoolEnoughToPartyBasedOnAge("James", staffAge))
            {
                Console.WriteLine("you still got it dude, don't let your class bring you down.");
            }
            else
            {
                Console.WriteLine("get your bitch ass outta here");
            }

            if (IsCoolEnoughToPartyBasedOnAge("Darion", staffAge))
            {
                Console.WriteLine("we were expecting you");
            }
            else
            {
                Console.WriteLine("we'll make an exception to the rule");
            }


            staffAge["Drew"] = 13;

            bool isPeterHere = staffAge.ContainsKey("Peter");

            if (staffAge.TryGetValue("Peter", out int petersAge))
            {
                Console.WriteLine("I see you're age Peter, it's not secret heh heh heh");
            }
            else
            {
                Console.WriteLine("I can't get a read on this guy...");
            }

            int drewsAge = staffAge["Drew"];
        }

        static bool IsCoolEnoughToPartyBasedOnAge(string name, Dictionary<string, int> staffAge)
        {
            bool isCoolEnough = staffAge[name] <= 30;
            return isCoolEnough;
        }

        static void WriteToConsole<T, U>(T message, U otherMessage)
        {
            Console.WriteLine(message);
            Console.WriteLine(otherMessage);
        }

    }
}
