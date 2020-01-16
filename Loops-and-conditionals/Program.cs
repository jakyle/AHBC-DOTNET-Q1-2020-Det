using System;

namespace Loops_and_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is the age?");

            //string userInput = Console.ReadLine();

            //decimal age = decimal.Parse(userInput);

            //if (age >= 21)
            //{
            //    Console.WriteLine("yeah, order?");
            //}
            //else
            //{
            //    Console.WriteLine("Leave, you're too young, I don't want to see your face ever again, ya filthy animal!");
            //}

            // While loop

            // ExerciseSix();

            const int tequilaMemeLimit = 3;
            int tequilaShots = 1;

            while (tequilaShots <= tequilaMemeLimit)
            {
                Console.WriteLine($"{tequilaShots}, tequila");
                tequilaShots++;
            }

            Console.WriteLine("FLOOR!");

            // Do While

            const int drinkLimit = 6;
            int amountConsumed = 0;

            do
            {
                Console.WriteLine("Yeah I'll have another");
                amountConsumed++;

            } while (amountConsumed <= drinkLimit);
            
            Console.WriteLine("heh heh, I'm good");


            // continue and break

            int counter = 0;

            while (true)
            {
                counter++;

                if (counter % 2 != 0)
                {
                    continue;
                }

                if (counter > 10)
                {
                    break;
                }

                Console.WriteLine("I'm even Stephens");
            }


            // the For loop dude

            for (int  i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}, is the amount of times we have looped");
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("I'm even in a for loop!");
                }
            }


            for (int i = 10; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}. It's an odd number");
                }
            }
            
        }

        static void ExerciseSix()
        {
            bool shouldContinue = true;

            while (shouldContinue)
            {
                Console.WriteLine("Hello world!");

                bool shouldValidate = true;
                string userInput;
                do
                {
                    Console.WriteLine("Would you like to continue [y/n]?");
                    userInput = Console.ReadLine();

                    if (userInput == "y" || userInput == "Y" || userInput == "N" || userInput == "n")
                    {
                        shouldValidate = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again.");
                    }

                } while (shouldValidate);

                if (userInput != "y" && userInput != "Y")
                {
                    shouldContinue = false;
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
