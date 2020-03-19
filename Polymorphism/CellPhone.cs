using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class CellPhone : IScreen, ICase, ICamera, IBattery
    {
        private uint _brightness;
        private double _protectionLevel = 5;
        private double _health = 100;
        private double _batteryHealth = 100;

        public void Charge(double durationMinutes)
        {
            _batteryHealth = durationMinutes;
        }

        public void Display(uint brighntess)
        {
            _brightness = brighntess;
        }

        public bool IsCracked()
        {
            return false;
        }

        public void Protect(double damageLevel)
        {
            _health = damageLevel - _protectionLevel;
        }

        public string TakePicture()
        {
            return "picture";
        }
    }

    public interface IScreen
    {
        void Display(uint brighntess);
        bool IsCracked();
    }

    public interface ICase
    {
        void Protect(double damageLevel);
    }

    public interface ICamera
    {
        string TakePicture();
    }

    public interface IBattery
    {
        void Charge(double durationMinutes);
    }

    public class Television : IScreen
    {
        private uint _brightness;

        public void Display(uint brighntess)
        {
            _brightness = brighntess;
        }

        public bool IsCracked()
        {
            return true;
        }
    }
}
