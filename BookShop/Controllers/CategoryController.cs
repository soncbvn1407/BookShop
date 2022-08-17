using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookShop.Controllers
{
    public class CategoryController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public CategoryController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        //load toàn bộ dữ liệu từ bảng
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(context.Category.ToList());
        }

        //xoá dữ liệu từ bảng
        public IActionResult Delete(int id)
        {
            var category = context.Category.Find(id);
            context.Category.Remove(category);
            context.SaveChanges();
            TempData["Message"] = "Delete category successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        public IActionResult Detail(int id)
        {
            var category = context.Category.Include(c => c.Books)  //Category - Book : 1 - M
                                     .Include(c => c.Detailed)  //Category - Detailed : M - 1
                                     .FirstOrDefault(c => c.Id == id);
            return View(category);
        }

        //thêm dữ liệu vào bảng
        //hàm 1: render ra view
        [HttpGet]
        public IActionResult Add()
        {
            //đẩy danh sách của detailed sang bảng Add Category
            ViewBag.Detailes = context.Detailed.ToList();
            return View();
        }

        //hàm 2: nhận và xử lý dữ liệu được gửi từ form
        [HttpPost]
        public IActionResult Add(Category category)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB
                context.Add(category);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Add category successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(category);
        }

        //sửa dữ liệu của bảng
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Detailes = context.Detailed.ToList();
            return View(context.Category.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(category);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit category successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(category);
        }
    }
}
