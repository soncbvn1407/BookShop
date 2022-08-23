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

        //delete data from table
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

        //add data to the table
        //function 1: render to view
        [HttpGet]
        public IActionResult Add()
        {
            //push the list of detailed to the Add Category . panel
            ViewBag.Detailes = context.Detailed.ToList();
            return View();
        }

        //function 2: receive and process data sent from form
        [HttpPost]
        public IActionResult Add(Category category)
        {
            //check data validity
            if (ModelState.IsValid)
            {
                //add data to DB
                context.Add(category);
                context.SaveChanges();
                //show success message about view
                TempData["Message"] = "Add category successfully !";
                //back to index page
                return RedirectToAction(nameof(Index));
            }
            //If the data is not valid, return the form to re-enter
            return View(category);
        }

        //edit table data
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Detailes = context.Detailed.ToList();
            return View(context.Category.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            //check data validity
            if (ModelState.IsValid)
            {
                //update data to Database
                context.Update(category);
                context.SaveChanges();
                //show success message about view
                TempData["Message"] = "Edit category successfully !";
                //back to index page
                return RedirectToAction(nameof(Index));
            }
            //If the data is not valid, return the form to re-enter
            return View(category);
        }
    }
}
