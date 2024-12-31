using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_Api.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; } = [];
    }
}
