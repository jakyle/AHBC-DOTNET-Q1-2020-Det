using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assessment_review.Models;

namespace assessment_review.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AgeCheck()
        {
            return View();
        }

        public IActionResult AgeGateKeeper(AgeCheckViewModel model)
        {
            if (model.Age >= 21)
            {
                return RedirectToAction("ShowBoozeMenu");
            }
            else
            {
                return RedirectToAction("NotOldEnough", new { Age = model.Age});
            }
        }

        [HttpGet]
        public IActionResult NotOldEnough(int age)
        {
            var model = new NotOldEnoughViewModel();
            model.Age = age;
            return View(model);
        }


        public IActionResult ShowBoozeMenu()
        {
            var booze = new ShowBoozeMenuViewModel();
            booze.Items = new List<Booze>();
            booze.Items.Add(new Booze("Beer", 2.88));
            booze.Items.Add(new Booze("Liqour", 10.22));
            booze.Items.Add(new Booze("Wine", 15.99));

            return View(booze);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
