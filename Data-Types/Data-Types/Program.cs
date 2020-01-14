using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            // Constants
            const string name = "James";
                
            Console.WriteLine("Hey user, what year is it?");

            // Hey user, I want you to type some stuff in the console

            /*
             *asdfasdf
             *
             *asdfasdfsadf
             *asdfasdf
             * 
             
             * */

            // INtro examples
            string userInput = Console.ReadLine();
            
            // print this user input into the console.
            Console.WriteLine(userInput);
            Console.WriteLine("Thanks user, you're my friend.");

            // Data Types
            string myName = "James";

            // numbers
            int numOne = 32;
            long longNum = 64;

            numOne = 31;

            // common value types
            int imNotAFloatingPointNumber = 32;
            bool imTeaching = true;
            double imAFloatingPointNumber = 13.2;
            char aLetter = 'a';
            float imFLoatingHere = 33.2F;
            decimal preciseNumber = 32.56M;

            preciseNumber = 555.23M;


            // Numbers and shit
            int sum = 1 + 2;
            int difference = 5 - 2;
            double formula = 1.0 / 2.0;

            // increntor .... help?

            int incrementOne = 1 + 1;

            // long hand increment
            incrementOne = incrementOne + 1;

            // short hand
            incrementOne += 1;

            // uber increment 
            incrementOne++;

            // decrement
            int decrement = 1;
            decrement = decrement - 1;
            decrement -= 1;
            decrement--;

            // product increment?
            int productIncrement = 2;
            productIncrement *= 1;

            // division decrement?
            int divisionDecrement = 1;
            divisionDecrement /= 1;

            int negativeNum = -23;

            // modulus 
            int modResult = 3 % 2;

            // Implicit casting
            int smallNum = 23;
            long longNumOne = smallNum;

            // Explicit casting

            smallNum = (int)longNumOne;

            double num = 32.2;
            int otherNum = (int)num;

            // ==============================
            //      conditions and booleans
            // ===================================

            int age = 19;

            //                     > =
            bool canBuyBooze = age >= 21 + 2;

            // Console.WriteLine("Can you buy booze?");
            // Console.WriteLine(canBuyBooze);

            // Relational Operators

            //     Equality Operator
            bool isEqual = 2 == 3;

            // Inequality Operator
            bool yeahButIsReallyEqual = 2 != 3;

            bool hasVoucher = true;
            bool isOldEnoughAndHasVoucher = age >= 21 && hasVoucher;
            bool isOldEnoughOrHasVoucher = age >= 21 || hasVoucher;
            bool doesNotHaveVoucher = !hasVoucher;

            bool reverseDude = !(age >= 21 && hasVoucher);

            if (isOldEnoughOrHasVoucher)
            {
                Console.WriteLine("okay, what do you want to drink my dude?");
            }

            if (hasVoucher)
            {
                Console.WriteLine("meh, good enough for me... are you.. are you a..  a cop?");
            }
            else
            {
                Console.WriteLine("Get outta kid, ya rascal!");
            }

        }
    }
}
