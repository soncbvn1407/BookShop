using BookShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //tự động tạo bảng
        public DbSet<Category> Category { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Detailed> Detailed { get; set; }
        public DbSet<Order> Order { get; set; }

        //create code to add initial data to the table
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedCategory(builder);
            SeedBook(builder);
            SeedDetailed(builder);
            //add data for 3 tables: User, Role, UserRole
            //=> Authentication (Login/Logout) + Authorization (Role Assign)
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
        }
        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "Admin"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Customer",
                    NormalizedName = "Customer"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "StoreOwner",
                    NormalizedName = "StoreOwner"
                }
                );
        }


        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "3"
                }
            );
        }

       
        private void SeedUser(ModelBuilder builder)
        {
            //tạo tài khoản test cho admin & customer
            var admin = new IdentityUser
            {
                Id = "1",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com"
            };

            var customer = new IdentityUser
            {
                Id = "2",
                Email = "customer@gmail.com",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com"
            };

            var storeowner = new IdentityUser
            {
                Id = "3",
                Email = "storeowner@gmail.com",
                UserName = "storeowner@gmail.com",
                NormalizedUserName = "storeowner@gmail.com"
            };

            //khai báo thư viện để mã hóa mật khẩu cho user
            var hasher = new PasswordHasher<IdentityUser>();

            //set mật khẩu đã mã hóa cho từng user
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");
            storeowner.PasswordHash = hasher.HashPassword(storeowner, "123456");

            //add 2 tài khoản test vào bảng user
            builder.Entity<IdentityUser>().HasData(admin, customer, storeowner);
        }

        private void SeedDetailed(ModelBuilder builder)
        {
            builder.Entity<Detailed>().HasData(
                new Detailed { Id = 1, Name = "DC Comics" },
                new Detailed { Id = 2, Name = "Supernatural" },
                new Detailed { Id = 3, Name = "Fantasy" },
                new Detailed { Id = 4, Name = "Extreme Sports" },
                new Detailed { Id = 5, Name = "Crime" }
                );
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "Batman: The Dark Knight Returns",
                    Author = "Stephen King",
                    Price = 6399,
                    Quantity = 10,
                    CategoryId = 1,
                    Date = DateTime.Parse("06/05/1997"),
                    Image = "https://upload.wikimedia.org/wikipedia/en/e/e9/Batman_The_Dark_Knight_Returns_%28film%29.jpg"
                },
                new Book
                {
                    Id = 2,
                    Name = "Doctor Sleep",
                    Author = "Stephen King",
                    Price = 4499,
                    Quantity = 30,
                    CategoryId = 2,
                    Date = DateTime.Parse("04/09/2013"),
                    Image = "https://img.thriftbooks.com/api/images/i/s/3775E4992634D153CA456BC6C572BA5138A1267D.jpg"
                },
                new Book
                {
                    Id = 3,
                    Name = "From Blood and Ash",
                    Author = "Stephen King",
                    Price = 7999,
                    Quantity = 20,
                    CategoryId = 3,
                    Date = DateTime.Parse("09/03/2020"),
                    Image = "https://m.media-amazon.com/images/I/51nh3JnQNsL.jpg"
                },
                new Book
                {
                    Id = 4,
                    Name = "The Awakening",
                    Author = "Stephen King",
                    Price = 1999,
                    Quantity = 50,
                    CategoryId = 3,
                    Date = DateTime.Parse("04/01/2020"),
                    Image = "https://m.media-amazon.com/images/I/51XzxAUT5QS.jpg"
                },
                new Book
                {
                    Id = 5,
                    Name = "Breath: The New Science of a Lost Art",
                    Author = "Stephen King",
                    Price = 1622,
                    Quantity = 25,
                    CategoryId = 4,
                    Date = DateTime.Parse("06/05/2020"),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/81NygdDiGRL._AC_UL604_SR604,400_.jpg"
                },
                new Book
                {
                    Id = 6,
                    Name = "Born to Run",
                    Author = "Stephen King",
                    Price = 999,
                    Quantity = 15,
                    CategoryId = 4,
                    Date = DateTime.Parse("09/03/2011"),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/81BAIsimy6L._AC_UL604_SR604,400_.jpg"
                },
                new Book
                {
                    Id = 7,
                    Name = "All Star Superman",
                    Author = "Stephen King",
                    Price = 8199,
                    Quantity = 35,
                    CategoryId = 1,
                    Date = DateTime.Parse("01/01/2011"),
                    Image = "https://upload.wikimedia.org/wikipedia/en/e/e9/Batman_The_Dark_Knight_Returns_%28film%29.jpg"
                },
                new Book
                {
                    Id = 8,
                    Name = "Overkill",
                    Author = "Stephen King",
                    Price = 2610,
                    Quantity = 45,
                    CategoryId = 5,
                    Date = DateTime.Parse("06/08/2022"),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/814dSvh3Q6L._AC_UL604_SR604,400_.jpg"
                },
                new Book
                {
                    Id = 9,
                    Name = "Pet Sematary",
                    Author = "Stephen King",
                    Price = 1021,
                    Quantity = 5,
                    CategoryId = 2,
                    Date = DateTime.Parse("07/01/2017"),
                    Image = "https://m.media-amazon.com/images/P/1501156705.01._SCLZZZZZZZ_SX500_.jpg"
                },
                new Book
                {
                    Id = 10,
                    Name = "The 6:20 Man: A Thriller",
                    Author = "Stephen King",
                    Price = 1539,
                    Quantity = 1,
                    CategoryId = 5,
                    Date = DateTime.Parse("02/01/2022"),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/912F2fID5XL._AC_UL604_SR604,400_.jpg"
                }
                ); 
        }

        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Comics", DetailedId = 1 },
                new Category { Id = 2, Name = "Horror", DetailedId = 2 },
                new Category { Id = 3, Name = "Romance", DetailedId = 3 },
                new Category { Id = 4, Name = "Sports", DetailedId = 4 },
                new Category { Id = 5, Name = "Mystery", DetailedId = 5 }
                );
        }
    }
}
