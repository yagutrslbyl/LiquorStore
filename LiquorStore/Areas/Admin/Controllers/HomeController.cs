using Microsoft.AspNetCore.Mvc;

namespace LiquorStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {

        public IActionResult Admin()
        {
            return View();
        }
    }
}
