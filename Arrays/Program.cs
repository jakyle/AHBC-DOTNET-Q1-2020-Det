using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            //                                0  1  2  3  4  
            int[] otherNumbers = new int[] { 13, 0, 5, 1, 2 };

            // int indexSeven = otherNumbers[7];

            int thirdNumberInArray = otherNumbers[2];

            int amountOfEvenNumbers = GetAmountOfEvenNumbers(otherNumbers);
            int numbersIsEven = GetAmountOfEvenNumbers(numbers);
            
            //
            //
            int amountOfVowels = GetVowelsInWords(new string[] { "Hello", "is", "there", "anybody", "out", "there"});

            string[] names = new string[] { "james", "jimmy", "larry" };

            int[][] nestedNumbersRedux = new[]
            {
                //   j   0  1  2  3          i
                new [] { 7, 2, 3, 4},     // 0 
                new [] { 13, 14, 99, 2},  // 1
                new [] { 33, 24, 3, 4}      // 2
            };

            int[][] nestedNumbers = new[]
            {
                //   j   0  1  2  3          i
                new [] { 1, 2, 3, 4},     // 0 
                new [] { 13, 14, 99, 2},  // 1
                new [] { 8, 2, 3, 4}      // 2
            };

            GetOddNumbers(nestedNumbers);
        }

        static int GetAmountOfEvenNumbers(int[] numbers)
        {
            int accumulator = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    accumulator++;
                }
            }

            return accumulator;
        }
        //  numbers = nestedNumbers
        static int GetOddNumbers(int[][] numbers)
        {
            int accumulator = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] % 2 != 0) 
                    {
                        accumulator++;
                    }
                }
            }

            return accumulator;
        }

        static int GetVowelsInWords(string[] words)
        {
            int accumulator = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    // words[i] == "hello"
                    switch (words[i].ToLower()[j])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            accumulator++;
                            break;
                        default:
                            break;
                    }
                }
            }

            return 0;
        }
    }
}
