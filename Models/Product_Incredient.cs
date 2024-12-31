namespace Coffee_Shop_Api.Models
{
    public class Product_Incredient
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int IncredientId { get; set; }
        public Ingredient? Incredient { get; set; }
        public decimal Amount { get; set; }
    }
}
