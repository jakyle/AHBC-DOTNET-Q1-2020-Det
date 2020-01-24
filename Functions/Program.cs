using System.Text.RegularExpressions;
using System;

namespace Functions
{
    class Program
    {
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

        static void Main(string[] args)
        {
            // Functions
            double areaOfMyRoom = FindArea(11.2, 23.6);
            double areaOfDarionsRoom = FindArea(69.2, 420);
            double volumeOfMyRoom = FindVolume(33.2, 56.1, 22.4);

            string[] ourNumbers = new[] { "123-123-1234", "321-321-4321", "sup dude" };
            
            for (int i = 0; i < ourNumbers.Length; i++)
            {
                if (IsValidPhoneNumber(ourNumbers[i]))
                {
                    Console.WriteLine("Hit me up dude");
                }
                else
                {
                    Console.WriteLine("Invalid Phone Number");
                }
            }

            

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
    }
}
