using Marlon_Vending_Machine.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Marlon_Vending_Machine.Interfaces;

namespace Marlon_Vending_Machine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductsDomain _productsDomain;

        public HomeController(ILogger<HomeController> logger, IProductsDomain productsDomain)
        {
            _logger = logger;
            _productsDomain = productsDomain;
        }

        public IActionResult Index()
        {
            var products = _productsDomain.GetProducts();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}