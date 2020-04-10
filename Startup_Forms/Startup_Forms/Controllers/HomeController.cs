
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Startup_Forms.Models;
using Startup_Forms.Services;

namespace Startup_Forms.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeFacade _homeFacade;

        public HomeController(IHomeFacade homeFacade)
        {
            _homeFacade = homeFacade;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new ContactViewModel();
            return View(model);
        }

        public IActionResult ContactDetails(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ErrorMessage = "This data is no good, try again user.... heh";
                return View("Contact", model);
            }

            var viewModel = _homeFacade.Map(model);
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
