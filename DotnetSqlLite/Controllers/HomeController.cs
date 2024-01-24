using DotnetSqlLite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotnetSqlLite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // testing connectivity
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                ProductName = "IPhone",
                Price = 45000,
                InStock = 150,
                UnitName = "Apple IPhone"
            });

            _context.Products.AddRange(products);
            _context.SaveChanges();

            return View();
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
