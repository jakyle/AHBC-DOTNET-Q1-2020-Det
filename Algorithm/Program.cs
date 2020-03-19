using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var algos = new AlgoBoy();

            algos.SumTwoNumbers(2, 3);


            var testOne = algos.IsPalindrome("racecar");
            var testTwo = algos.IsPalindrome("James");
            var testThree = algos.IsPalindrome("mom");

            var testStackOne = algos.IsPalindromeStack("racecar");
            var testStackTwo = algos.IsPalindromeStack("James");
            var testStackThree = algos.IsPalindromeStack("mom");

            var array = new[] { 2, 4, 8, 0, 9, 3, 6 };
            algos.BubbleSort(array);

            Console.ReadLine();
        }
    }
}
