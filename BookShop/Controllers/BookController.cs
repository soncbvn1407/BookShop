using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookShop.Controllers
{
    public class BookController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        

        //load toàn bộ dữ liệu từ bảng
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            //xếp book mới được hiển thị ở đầu danh sách (sort theo id giảm dần)
            var books = context.Book.OrderByDescending(b => b.Id).ToList();
            return View(books);
        }

        [Authorize(Roles = "Customer")]
        //hiển thị giao diện dạng card cho khách hàng order sản phẩm
        public IActionResult Store()
        {
            return View(context.Book.ToList());
        }

        //xoá dữ liệu từ bảng
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            // tao object book 
            var book = context.Book.Find(id);
            context.Book.Remove(book);
            context.SaveChanges();
            TempData["Message"] = "Delete book successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        [Authorize(Roles = "Admin, Customer")]
        public IActionResult Detail(int id)
        {
            var book = context.Book.Include(b => b.Category)  //Book - Category : M - 1
                                   .ThenInclude(c => c.Detailed)  //Category - Detailed : M - 1
                                   .FirstOrDefault(c => c.Id == id);
            return View(book);
        }

        //thêm dữ liệu vào bảng
        //hàm 1: render ra view
        [HttpGet]
        public IActionResult Add()
        {
            //đẩy danh sách của detailed sang bảng Add Book
            ViewBag.Categories = context.Category.ToList();
            return View();
        }

        //hàm 2: nhận và xử lý dữ liệu được gửi từ form
        [HttpPost]
        public IActionResult Add(Book book)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB
                context.Add(book);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Add book successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(book);
        }

        //sửa dữ liệu của bảng
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = context.Category.ToList();
            return View(context.Book.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(book);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit book successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(book);
        }

        public IActionResult PriceAsc()
        {
            var books = context.Book.OrderBy(b => b.Price).ToList();
            return View("Store", books);
        }

        public IActionResult PriceDesc()
        {
            var books = context.Book.OrderByDescending(b => b.Price).ToList();
            return View("Store", books);
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var books = context.Book.Where(b => b.Name.Contains(keyword)).ToList();
            return View("Store", books);
        }
    }
}
