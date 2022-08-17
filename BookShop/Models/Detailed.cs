using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    //Detailed - Category: One To Many
    public class Detailed
    {
       public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
