using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class AlgoBoy
    {
        public void SumTwoNumbers(int numOne, int numTwo)
        {
            int x;
            int y;
            int z;

            x = numOne;
            y = numTwo;

            z = x + y;
            Console.WriteLine(z);
        }


        // 
        //             
        // word is "rac e car"

        // O( n^2 )  Time Complexity
        // O(n)      linear
        // O(log(n)) logrithmic
        // O(1)
        public bool IsPalindrome(string word)
        {
            //       0     6 7
            // word: racecar
            var halfLength = word.Length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                var firstHalf = word[i];
                var secondHalf = word[word.Length - 1 - i];

                if (firstHalf != secondHalf)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPalindromeStack(string word)
        {
            var letterStack = new Stack<char>();
            var halfLength = word.Length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                letterStack.Push(word[i]);
            }

            if (word.Length % 2 != 0)
            {
                halfLength++;
            }

            for (int i = halfLength; i < word.Length; i++)
            {
                var letter = letterStack.Pop();

                if (letter != word[i])
                {
                    return false;
                }
            }

            return true;
        }

        // input
        // [2, 4, 8, 0, 9, 3, 6]
        // sorted
        // [0, 2, 3, 4, 6, 8, 9]
        public void BubbleSort(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] > items[j])
                    {
                        var itemI = items[i];
                        var itemJ = items[j];

                        items[i] = itemJ;
                        items[j] = itemI;
                    }
                }
            }
        }
    }
}
