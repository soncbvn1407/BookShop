using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    //Category - Book: One To Many
    //Category - Detailed: Many To One
    public class Category
    {
        public int Id { get; set; } //PK

        [Required]
        [Display(Name = "Category Name")]
        [MinLength(3, ErrorMessage = "Category Name must be at least 3 characters")]
        [MaxLength(30, ErrorMessage = "Category Name cannot be more than 30 characters")]
        public string Name { get; set; }

        //set thuộc tính liên kết sang bảng Book
        public ICollection<Book> Books { get; set; }

        [Required]
        [Display(Name = "Country Name")]
        public int DetailedId { get; set; }

        public Detailed Detailed { get; set; }

    }
}
