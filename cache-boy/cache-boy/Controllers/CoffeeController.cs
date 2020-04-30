using Microsoft.AspNetCore.Mvc;
using cache_boy.Models.Coffee;
using cache_boy.Service;
using System.Linq;
using cache_boy.Models.Coffee.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cache_boy.Controllers
{
    public class CoffeeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public CoffeeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Coffees()
        {
            var model = new CoffeesViewModel();
            var CoffeeDBOList = await _coffeeRepository.SelectAllCoffee();

            model.Coffees = CoffeeDBOList
                .Select(coffeeDBO => new CoffeeNameAndID() { Name = coffeeDBO.Name, ID = coffeeDBO.ID })
                .ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult AddCoffee()
        {
            var model = new AddCoffeeViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddCoffee(AddCoffeeViewModel postModel)
        {
            var dboCoffee = new CoffeeDBO();
            dboCoffee.Name = postModel.Name;
            dboCoffee.Price = postModel.Price;
            dboCoffee.Description = postModel.Description;

            _coffeeRepository.InsertIntoCoffee(dboCoffee);
            
            return RedirectToAction(nameof(Coffees));
        }

        public IActionResult DeleteCoffee(int coffeeId)
        {
            _coffeeRepository.DeleteSelectedCoffee(coffeeId);
            return RedirectToAction(nameof(Coffees));
        }

        [HttpGet]
        public IActionResult UpdateCoffee(int coffeeID)
        {
            var model = new UpdateCoffeeViewModel();

            var currentCoffee = _coffeeRepository.SelectOneCoffee(coffeeID);


            model.NewName = string.Empty;
            model.OldName = currentCoffee.Name;

            model.NewDescription = string.Empty;
            model.OldDescription = currentCoffee.Description;

            model.NewPrice = default(int);
            model.OldPrice = currentCoffee.Price;

            model.ID = coffeeID;

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateCoffee(UpdateCoffeeViewModel model)
        {
            var dboCoffee = new CoffeeDBO();
            dboCoffee.Name = model.NewName;
            dboCoffee.Price = model.NewPrice;
            dboCoffee.Description = model.NewDescription;
            dboCoffee.ID = model.ID;

            _coffeeRepository.UpdateSelectedCoffee(dboCoffee);

            return RedirectToAction(nameof(Coffees));
        }
    }
}
