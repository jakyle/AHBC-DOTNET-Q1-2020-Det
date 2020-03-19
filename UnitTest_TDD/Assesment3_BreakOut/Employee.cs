using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment3_BreakOut
{
    public class Employee
    {
        public string Name { get; set; }

        public string JobTitle { get; set; }

        public Employee()
        {

        }
        public Employee(string name, string jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;
        }
    }
}
