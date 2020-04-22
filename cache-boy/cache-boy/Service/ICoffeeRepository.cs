using cache_boy.Models.Coffee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cache_boy.Service
{
    public interface ICoffeeRepository
    {
        //void AddCoffee(string coffeeName);
        //void DeleteCoffee(string coffeeName);
        //void UpdateCoffee(string newName, string oldName);
        IEnumerable<CoffeeDBO> SelectAllCoffee();
    }
}
