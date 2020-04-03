using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_app_boy.Models;

namespace Web_app_boy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            var theCatsMeow = GetViewModel(() => 
            {
                var hobbies = new List<string> { "Coding", "Gaming", "Poker" };
                return new AboutMeViewModel("James", "Instructor / Software Engineer", hobbies);
            });

            var burger = MakeBurger(() =>
            {
                var ingredient = "lettuce";
                return ingredient;
            })

            return View(theCatsMeow);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private AboutMeViewModel GetViewModel(Func<AboutMeViewModel> fn)
        {
            var otherfn = fn;
            var viewModel = otherfn();
            return viewModel;
        }

        private string MakeBurger(Func<string> ingedientsFn)
        {
            // cook pattie, get bread
            var ingredients = ingedientsFn();

            return "yummy burger";
        }
    }
}
