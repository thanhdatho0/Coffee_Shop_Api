using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_Api.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool Available { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Image> Images { get; set; } = [];
        public ICollection<Product_Incredient> Incredients { get; set; } = [];
        public ICollection<OrderDetail> OrderDetails { get; set; } = [];
    }
}
