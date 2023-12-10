using E_commerce.Models;
using E_commerce.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _context;

        public HomeController(ILogger<HomeController> logger, IProductService context)
        {
            _context = context;
            _logger = logger;
        }

        // GET: ProductController
        public IActionResult Index()
        {
            var products = _context.GetAllProductsByCategory(100, 4);
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