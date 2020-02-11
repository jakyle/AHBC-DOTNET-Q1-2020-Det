using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var custodianA = new Custodian()
            {
                Tools = new List<string>() { "Plunger", "Hammer" },
                Salary = 2_000.00m
            };
            var custodianB = new Custodian()
            {
                Tools = new List<string>() { "Nailgun", "Mop" },
                Salary = 2_500.00m
            };
            var manager = new Manager()
            {
                StaffMembers = new List<string>() { "Mario", "Luigi" },
                Salary = 2_500.00m
            };
            var person = new Person();

            //EmployeeBase employeeBoy = new EmployeeBase();
            //employeeBoy.Age = 5;

            var employees = new List<EmployeeBase>();
            employees.Add(custodianA);
            employees.Add(custodianB);
            employees.Add(manager);

            foreach (EmployeeBase employee in employees)
            {
                Console.WriteLine(employee.Salary);
                Console.WriteLine(employee.GetPayPeriodType());
            }

            var messengers = new List<Messenger>();
            var textMessenger = new TextMessenger();
            var emailMessenger = new EmailMessenger();

            messengers.Add(textMessenger);
            messengers.Add(emailMessenger);

            foreach (Messenger messenger in messengers)
            {
                messenger.SendMessage("50% off these shoes dude!");
            }


            // interfaces
            CellPhone cellPhone = new CellPhone();
            Television television = new Television();

            var screens = new List<IScreen>();

            screens.Add(cellPhone);
            screens.Add(television);

            foreach (var screen in screens)
            {
                Console.WriteLine(screen.IsCracked());
            }

        
        }
    }
}
