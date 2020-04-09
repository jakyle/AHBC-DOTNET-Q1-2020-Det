
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Startup_Forms.Models;
using Startup_Forms.Services;

namespace Startup_Forms.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPaymentValidator _paymentValidator;
        private readonly ILogger<HomeController> _logger;
        private readonly IAllCapsContactService _allCapsContactService;

        public HomeController(
            ILogger<HomeController> logger, 
            IPaymentValidator paymentValidator,
            IAllCapsContactService allCapsContactService)
        {
            _paymentValidator = paymentValidator;
            _logger = logger;
            _allCapsContactService = allCapsContactService;
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
            _allCapsContactService.CapsAllProperties(model);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
