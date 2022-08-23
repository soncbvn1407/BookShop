using System;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    //Order - Book: Many To One
    public class Order
    {
        public int Id { get; set; }
        public int BookId { get; set; }  //FK : liên kết sang PK của bảng Book
        public Book Book { get; set; }  //dùng để truy xuất các thông tin của bảng Book
        public string UserEmail { get; set; }
        public string Status { get; set; }

        [Required]
        public int OrderQuantity { get; set; }

        [Required]
        public double OrderPrice { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
    }
}
