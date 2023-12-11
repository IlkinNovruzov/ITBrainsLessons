using System.ComponentModel.DataAnnotations;

namespace Grocery.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
