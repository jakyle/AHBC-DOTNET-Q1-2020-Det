using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Linq;

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
                "Cafe Con Leche",  // {"Cafe", "Con", "Leche"}
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
            return GetThreeWordCoffesAllCaps();
        }

        public void UpdateCoffee(string newName, string oldName)
        {
            var oldNameIndex = Coffees.IndexOf(oldName);
            Coffees[oldNameIndex] = newName;
        }

        private IList<string> GetCoffessAllCaps()
        {
            // Looping way of doing the thing
            var coffeesAllCaps = new List<string>();
            foreach (var coffee in Coffees)
            {
                var allCapsCoffee = coffee.ToUpper();

                coffeesAllCaps.Add(allCapsCoffee);
            }

            // the Linq way
            return Coffees
                .Select(coffee => coffee.ToUpper())
                .ToList();
        }

        private IList<string> GetThreeWordCoffees()
        {
            var coffeesWithOnlyThreeWords = new List<string>();
            foreach (var coffee in Coffees)
            {
                if (coffee.Split(" ").Length <= 3)
                {
                    coffeesWithOnlyThreeWords.Add(coffee);
                }
            }


            var coffeesWithOnlyThreeWordsLinqEdition = Coffees
                .Where(coffee => {
                    return coffee.Split(" ").Length <= 3;
                 })
                .ToList();

            return coffeesWithOnlyThreeWordsLinqEdition;
        }

        private IList<string> GetThreeWordCoffesAllCaps()
        {

            var name = "Darion".Select(letter => letter + 1).ToString();

            var coffeesWithOnlyThreeWordsLinqEdition = Coffees
                .Where(coffee => coffee.Split(" ").Length <= 3)
                .Select(coffee => coffee.ToUpper())
                .ToList();

            return coffeesWithOnlyThreeWordsLinqEdition;
        }


    }
}
