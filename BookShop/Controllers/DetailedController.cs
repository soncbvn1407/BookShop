using BookShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookShop.Controllers
{
    public class DetailedController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public DetailedController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IActionResult Detail(int id)
        {
            var detailed = context.Detailed.Include(d => d.Categories)      //Detailed - Category: 1 - M
                                         .ThenInclude(c => c.Books) //Detailed => Category => Book
                                         .FirstOrDefault(d => d.Id == id);
            /* Note:
             * Nếu 2 bảng có kết nối trực tiếp (đi thẳng) thì dùng hàm Include
             * Nếu 2 bảng có kết nối gián tiếp (đi vòng) thông qua bảng trung gian thì dùng hàm ThenInclude
             */
            return View(detailed);
        }
    }
}
