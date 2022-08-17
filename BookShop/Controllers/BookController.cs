using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
