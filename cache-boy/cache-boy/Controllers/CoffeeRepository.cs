using System.Collections.Generic;

namespace cache_boy.Controllers
{
    public static class CoffeeRepository
    {
        public static ICollection<string> GetInitialCoffees()
        {
            var coffees = new List<string>()
            {
                "Cafe Con Leche",
                "Caramel Machiato",
                "Yummy boys coffee",
                "Vanilla Late",
                "Hot Chocolate"
            };

            return coffees;
        }
    }
}
