using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bootstrap.Models;
using bootstrap.services;

namespace bootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOfFireAndIceClient _ofFireAndIceClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IOfFireAndIceClient ofFireAndIceClient)
        {
            _ofFireAndIceClient = ofFireAndIceClient;
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

        public async Task<IActionResult> Books()
        {
            var booksResponse = await _ofFireAndIceClient.GetBooks();

            var model = new BooksViewModel();
            model.Books = booksResponse.Select(br => new BookModel
            {
                Name = br.name,
                Authors = br.authors.ToList(),
                NumberOfPages = br.numberOfPages,
                Released = br.released,
                Characters = br.characters.ToList()
            })
            .ToList();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
