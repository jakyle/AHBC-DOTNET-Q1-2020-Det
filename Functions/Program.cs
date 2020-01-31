using System.Text.RegularExpressions;
using System;

namespace Functions
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Functions
            double areaOfMyRoom = FindArea(11.2, 23.6);
            double areaOfDarionsRoom = FindArea(69.2, 420);
            double volumeOfMyRoom = FindVolume(33.2, 56.1, 22.4);
            double myLivingRoom = FindArea(22.2, 33.1);


            double valueOne = 10.0;
            double valueTwo = FindArea(5, 2);

            //                                  0             1                2
            string[] ourNumbers = new[] { "123-123-1234", "321-321-4321", "sup dude" };
            
            for (int i = 0; i < ourNumbers.Length; i++)
            {
                bool isValidPhoneNumber = IsValidPhoneNumber(ourNumbers[i]);
                if (isValidPhoneNumber)
                {
                    Console.WriteLine("Hit me up dude");
                }
                else
                {
                   Console.WriteLine("Invalid Phone Number");
                }
            }

            PrintHello();
            PrintMessage("Sup dude");
            PrintMessage("hello", "how are you");

            Console.WriteLine('a');

            int userInput = GetValidatedUserInt();

            string inputtedNumber = "123-123-1234";
            if (TryParsePhoneNumber(inputtedNumber, out string validPhoneNumber))
            {
                validPhoneNumber
            }
            else
            {

            }
        }

        static int AddTwoNumbers(int numOne, int numTwo)
        {
            int summedResult = numOne + numTwo;

            return summedResult;
        }

        static double FindArea(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double FindVolume(double length, double width, double height)
        {
            double volume = FindArea(length, width) * height;
            return volume;
        }
        

        static bool IsValidPhoneNumber(string phoneNumber)
        {
            Regex pattern = new Regex(@"\(?[0-9]{3}\)?-[0-9]{3}-[0-9]{4}|\([0-9]{3}\) [0-9]{3}-[0-9]{4}");
            bool isValidPhoneNumber = pattern.IsMatch(phoneNumber);
            return isValidPhoneNumber;
        }

        static void PrintHello()
        {
            Console.WriteLine("Hello world!");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine($"Hello, your message is: {message}");
        }

        static void PrintMessage(string messageOne, string messageTwo)
        {
            Console.WriteLine($"Hello, your first message is: {messageOne}");
            Console.WriteLine($"Hello, your second message is: {messageTwo}");
        }


        static int GetValidatedUserInt()
        {
            // 1. Get user input
            // 2. TRY to parse user input into int
            // 3. if valid input return input
            // 4. repeats step 1 - 3
            
            while (true)
            {
                Console.WriteLine("Please enter an integer");
                string userInput = Console.ReadLine();
                
                if (int.TryParse(userInput, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid integer");
                }
            }
        }

        static bool TryParsePhoneNumber(string input, out string phoneNumber)
        {
            if (IsValidPhoneNumber(input))
            {
                phoneNumber = input;
                return true;
            } 
            else
            {
                phoneNumber = string.Empty;
                return false;
            }
        }
        
    }
}
