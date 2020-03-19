using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class WinterHat
    {
        
        public WinterHat()
        {

        }

        public WinterHat(string color, double size)
        {
            this._pigLatinColor = $"{color}way";
            this.Size = size;
        }

        
        private string _pigLatinColor;
        public string Color
        {
            get
            {
                return _pigLatinColor.Substring(_pigLatinColor.Length - 3);
            }
            
            set
            {
                var pigColor = $"{value}way";
                _pigLatinColor = pigColor;
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
