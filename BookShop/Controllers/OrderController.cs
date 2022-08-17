using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookShop.Controllers
{
    public class OrderController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public OrderController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Action Post dùng để nhận dữ liệu từ form, xác thực dữ liệu
        //và lưu vào database nếu dữ liệu hợp lệ sau đó redirect về trang Index
        [HttpPost]
        public IActionResult Make(int id, int quantity)
        {
            //tạo Order mới
            var order = new Order();
            //set giá trị trong từng thuộc tính của Order
            var book = context.Book.Find(id);
            order.Book = book;
            order.BookId = id;
            order.OrderQuantity = quantity;
            order.OrderPrice = book.Price * quantity;
            order.OrderDate = DateTime.Now;
            order.UserEmail = User.Identity.Name;
            //add Order vào DB
            context.Order.Add(order);
            //trừ quantity của book
            book.Quantity -= quantity;
            context.Book.Update(book);
            //lưu cập nhật vào DB
            context.SaveChanges();
            //gửi về thông báo order thành công
            TempData["Success"] = "Order book successfully !";
            //redirect về trang book store
            return RedirectToAction("Store", "Book");
        }
    }
}
