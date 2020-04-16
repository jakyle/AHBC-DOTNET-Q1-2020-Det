using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;

namespace cache_boy.Service
{
    public class CoffeeRepository : ICoffeeRepository
    {
        const string coffeeKey = "coffees";
        private readonly IMemoryCache _memoryCache;

        public CoffeeRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        private IList<string> Coffees
        { 
            get
            {
                IList<string> coffees;
                if (!_memoryCache.TryGetValue(coffeeKey, out coffees))
                {
                    coffees = GetInitialCoffees();
                    _memoryCache.Set(coffeeKey, coffees);
                }

                return coffees;
            } 
        }

        private static IList<string> GetInitialCoffees()
        {
            var coffees = new List<string>()
            {
                "Cafe Con Leche",
                "Caramel Machiato",
                "Yummy boys coffee",  // "not so yummy boys"
                "Vanilla Late",
                "Hot Chocolate, Darion Special"
            };

            return coffees;
        }

        public void AddCoffee(string coffeeName)
        {
            Coffees.Add(coffeeName);
        }

        public void DeleteCoffee(string coffeeName)
        {
            Coffees.Remove(coffeeName);
        }

        public ICollection<string> GetAllCoffee()
        {
            return Coffees;
        }

        public void UpdateCoffee(string newName, string oldName)
        {
            var oldNameIndex = Coffees.IndexOf(oldName);
            Coffees[oldNameIndex] = newName;   
        }
    }
}
