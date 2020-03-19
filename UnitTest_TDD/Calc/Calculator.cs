using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    public class Calculator
    {
        public int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }


        public int[] BubbleSort(int[] arr) 
        {
            var newArray = new int[arr.Length];
            arr.CopyTo(newArray, 0);

            for (int i = 0; i < newArray.Length; i++) 
            {
                for (int j = 0; j < newArray.Length; j++) 
                {
                    if (newArray[j] > newArray[i]) 
                    {
                        var valueI = newArray[i];
                        var valueJ = newArray[j];

                        newArray[i] = valueJ;
                        newArray[j] = valueI;
                    }
                }
            }

            return newArray;
        }
    }
}
