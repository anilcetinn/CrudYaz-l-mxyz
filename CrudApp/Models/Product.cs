using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class Product
    {
      public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = "";
        [MaxLength(100)]
        public string Brand { get; set; } = "";
        [MaxLength(100)]
        public string Category { get; set; } = "";
        [Precision(16,2)]
        public decimal Price { get; set; }
        [MaxLength(100)]
        public string Description { get; set; } = "";
        public DateTime CreatedTime { get; set; }  

    }
}
