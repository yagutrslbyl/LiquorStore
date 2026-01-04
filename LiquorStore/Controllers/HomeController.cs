using LiquorStore.DAL;
using Microsoft.AspNetCore.Mvc;

namespace LiquorStore.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult ProductSingle(int? id)
        {
            var product = _context.Products.FirstOrDefault(x => x.ID == id);

            return View(product);
        }
    }
}
