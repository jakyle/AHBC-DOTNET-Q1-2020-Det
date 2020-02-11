using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Person
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public string HairColor { get; set; }
    }

    public abstract class EmployeeBase : Person
    {
        public DateTime StartTime { get; set; }
        public decimal Salary { get; set; }
        public string Title { get; set; }

        public abstract string GetPayPeriodType();
        
    }

    public class Manager : EmployeeBase
    {
        public List<string> StaffMembers { get; set; }

        public override string GetPayPeriodType()
        {
            return "I'm salary.. I take a lot of vacation!";
        }
    }

    public class Custodian : EmployeeBase
    {
        public List<string> Tools { get; set; }

        public override string GetPayPeriodType()
        {
            return "I'm hourly dude... I'm over worked... fuck off";
        }
    }
}
