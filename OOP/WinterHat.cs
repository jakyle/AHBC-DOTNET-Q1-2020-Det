using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class WinterHat
    {


        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }


        
        public double Size { get; set; } // Auto Property


        public void WearHat()
        {
            // some code to wear hat.
        }

        private string ThrowAHat()
        {
            return "I just threw a hat";
        }
    }
}
