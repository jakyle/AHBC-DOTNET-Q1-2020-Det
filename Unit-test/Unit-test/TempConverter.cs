using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_test
{
    public class TempConverter
    {
        public string ConvertTo(string measurementType, double temp)
        {

            double celsius = temp - 32;
            double convert = 5.0 / 9.0;
            double doubleAnswer = celsius * convert;
            int result = (int)doubleAnswer;


            return $"{result}(C)";
        }
    }
}
