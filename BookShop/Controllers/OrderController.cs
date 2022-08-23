using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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

        [Authorize(Roles = "StoreOwner")]
        public IActionResult Index()
        {
            var od = context.Order.ToList();

            foreach (var o in od)
            {
                if (o.Status == null)
                {
                    o.Status = "Pending";
                    context.Order.Update(o);
                    context.SaveChanges();
                }
            }
            return View(context.Order.OrderBy(o => o.Id).ToList());
        }



        [Authorize(Roles = "Customer")]
        public IActionResult Cart()
        {
            // Declare "od" to save all orders.
            var od = context.Order.ToList();
            // Create a list to contain orders belonging to a user
            List<Order> ods = new List<Order>();
            foreach (var o in od)
            {
                if (o.UserEmail == User.Identity.Name)
                {
                    ods.Add(o);
                }
            }
            return View(ods.ToList());
        }

        // Accept Order
        [Authorize(Roles = "Admin")]
        public IActionResult Accept(int id)
        {
            var order = context.Order.Find(id);
            order.Status = "Accept";
            context.Update(order);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Reject Order
        [Authorize(Roles = "Admin")]
        public IActionResult Reject(int id)
        {
            var order = context.Order.Find(id);
            order.Status = "Reject";
            context.Update(order);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Cancel Order
        [Authorize(Roles = "Customer")]
        public IActionResult Remove(int id)
        {
            var order = context.Order.Find(id);
            var b = context.Book.Find(order.BookId);
            b.Quantity = b.Quantity + order.OrderQuantity;
            context.Order.Remove(order);
            context.SaveChanges();
            TempData["Message"] = "Cancel order successfully !";
            return RedirectToAction("Cart");
        }

        //xoá dữ liệu từ bảng
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var order = context.Order.Find(id);
            var b = context.Book.Find(order.BookId);
            b.Quantity = b.Quantity + order.OrderQuantity;

            context.Order.Remove(order);
            context.SaveChanges();
            TempData["Message"] = "Delete order successfully !";
            return RedirectToAction("Index");
        }


        //Action Post is used to receive data from the form, validate data
        //and save it to the database if the data is valid then redirect to the Index page
        [HttpPost]
        public IActionResult Make(int id, int quantity)
        {
            //Create New Order
            var order = new Order();
            //set value in each attribute of Order
            var book = context.Book.Find(id);
            order.Book = book;
            order.BookId = id;
            order.OrderQuantity = quantity;
            order.OrderPrice = book.Price * quantity;
            order.OrderDate = DateTime.Now;
            order.UserEmail = User.Identity.Name;
            //add Order to DB
            context.Order.Add(order);
            //minus book's quantity
            book.Quantity -= quantity;
            context.Book.Update(book);
            //save update to DB
            context.SaveChanges();
            //Send notification of order success
            TempData["Success"] = "Order book successfully !";
            //redirect to book store page
            return RedirectToAction("Store", "Book");
        }
    }
}
