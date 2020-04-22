using Microsoft.AspNetCore.Mvc;
using cache_boy.Models.Coffee;
using cache_boy.Service;
using System.Linq;

namespace cache_boy.Controllers
{
    public class CoffeeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public CoffeeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        public IActionResult Coffees()
        {
            var model = new CoffeesViewModel();
            var coffeesDBO = _coffeeRepository.SelectAllCoffee();
            model.Coffees = coffeesDBO.Select(coffeeDBO => coffeeDBO.Name).ToList();

            return View(model);
        }

        public IActionResult AddCoffee()
        {
            var model = new AddCoffeeViewModel();
            return View(model);
        }

        //public IActionResult AddedCoffee(AddCoffeeViewModel postModel)
        //{
        //    _coffeeRepository.AddCoffee(postModel.Name);
        //    return RedirectToAction(nameof(Coffees));
        //}

        //public IActionResult DeleteCoffee(string coffeeName) // Mocha-Latte   --> https://localhost:5001/Coffee/DeleteCoffee?coffeeName=Cafe Con Leche
        //{
        //    _coffeeRepository.DeleteCoffee(coffeeName);
        //    return RedirectToAction(nameof(Coffees));
        //}

        //public IActionResult UpdateCoffee(string coffeeName)
        //{
        //    var model = new UpdateCoffeeViewModel();
        //    model.NewName = string.Empty;
        //    model.OldName = coffeeName;

        //    return View(model);
        //}

        //public IActionResult UpdatedCoffee(UpdateCoffeeViewModel model) 
        //{
        //    _coffeeRepository.UpdateCoffee(model.NewName, model.OldName);

        //    return RedirectToAction(nameof(Coffees));
        //}
    }
}
