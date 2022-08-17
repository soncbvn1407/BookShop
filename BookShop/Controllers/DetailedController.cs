using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class DetailedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
