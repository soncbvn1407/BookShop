using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BookShop.Models
{
    //Book - Category: Many To One
    //Book - Order: One To Many
    public class Book
    {
        public int Id { get; set; } //PK

        [Required]
        [MinLength(3, ErrorMessage = "Book Name must be at least 3 characters")]
        [MaxLength(50, ErrorMessage = "Book Name cannot be more than 50 characters")]
        public string Name { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Quantity must be between 0 and 100")]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 10000, ErrorMessage = "Price must be between 1$ and 10000$")]
        public double Price { get; set; }

        public string Author { get; set; }

        [Required]
        [Url]
        public string Image { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //set thuộc tính liên kết sang bảng Category
        [Required]
        [Display(Name = "Category name")]
        public int CategoryId { get; set; } //FK

        public Category Category { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
