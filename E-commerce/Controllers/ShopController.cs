using E_commerce.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _context;

        public ShopController( IProductService context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.GetAllProductsByCategory(100, 4);
            return View(products);
        }
    }
}
