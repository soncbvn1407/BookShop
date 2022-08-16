using System.Collections.Generic;

//relationship: Category - Book: Many To Many
namespace BookShop.Models
{
    public class Category
    {
        public int Id { get; set; } //PK
        public string Name { get; set; }

        //set thuộc tính liên kết sang bảng Book
        public ICollection<Book> Books { get; set; }

    }
}
