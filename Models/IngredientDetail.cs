namespace Coffee_Shop_Api.Models
{
    public class IngredientDetail
    {
        public int IncredientId { get; set; }
        public Ingredient? Incredient { get; set; }
        public decimal ImportedQuantity { get; set; }
        public decimal Cost { get; set; }
        public DateTime ImportedDate { get; set; }
    }
}
