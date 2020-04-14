using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cache_boy.Models;
using Microsoft.Extensions.Caching.Memory;
using cache_boy.Models.Coffee;

namespace cache_boy.Controllers
{
    public class CoffeeController : Controller
    {
        private readonly IMemoryCache _memoryCache;

        public CoffeeController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;

            if (!memoryCache.TryGetValue("coffees", out var coffee))
            {
                memoryCache.Set("coffees", CoffeeRepository.GetInitialCoffees());
            }
        }

        public IActionResult Coffees()
        {
            var model = new CoffeesViewModel();
            if (_memoryCache.TryGetValue("coffees", out ICollection<string> coffees))
            {
                model.Coffees = coffees;
            }

            return View(model);
        }

        public IActionResult AddCoffee()
        {
            var model = new AddCoffeeViewModel();
            return View(model);
        }

        public IActionResult PostCoffee(AddCoffeeViewModel postModel)
        {

            if(_memoryCache.TryGetValue("coffees", out ICollection<string> coffee))
            {
                coffee.Add(postModel.Name);
            }


            return View();
        }

        public IActionResult DeleteCoffee(string name)
        {
            return View();
        }
    }
}
