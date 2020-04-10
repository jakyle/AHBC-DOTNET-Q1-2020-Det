using Startup_Forms.Models;

namespace Startup_Forms.Services
{
    public class AllCapsContactService : IAllCapsContactService
    {
        public void CapsAllProperties(ContactViewModel model)
        {
            model.EmailAddress = model.EmailAddress.ToUpper();
            model.Name = model.Name.ToUpper();
        }

        public void CapsEverOtherLetter(ContactViewModel model)
        {
            model.EmailAddress = model.EmailAddress.ToUpper();
            model.Name = model.Name.ToUpper();
        }
    }


    public interface ICar
    {
        void Drive();

    }

    public interface IPrintPaper
    {
        void PrintPaper();

    }


    public class Sedan : ICar
    {
        public void Drive()
        {
            System.Console.WriteLine("vroom vroom");
        }
    }

    public class Truck : ICar
    {
        public void Drive()
        {
            System.Console.WriteLine("vroom vroom");
        }
    }
}
