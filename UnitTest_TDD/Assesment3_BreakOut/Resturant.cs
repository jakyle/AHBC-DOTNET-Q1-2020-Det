using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment3_BreakOut
{
    public class Resturant
    {
        public int MenuItems { get; set; }

        public List<Employee> Employees { get; set; }

        public Resturant()
        {
            MenuItems = 0;
            var grace = new Employee("Grace", "Manager");
            var james = new Employee("James", "Cook");
            var darion = new Employee("Darion", "Server");
            Employees = new List<Employee>
            {
                grace, 
                james,
                darion 
            };
            var chris = new Employee();
           
        }


        public bool IsResturantOpen()
        {
            return MenuItems >= 3 && Employees.Count >= 3;
        }
    }
}
