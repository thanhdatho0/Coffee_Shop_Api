using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_Api.Models
{
    public class Ingredient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IncredientId { get; set; }
        public required string IncredientName { get; set; }
        public decimal InStock { get; set; }
        public required string Unit { get; set; }
        public DateTime LastImportedDate { get; set; }
        public ICollection<IngredientDetail> IncredientDetails { get; set; } = [];
        public ICollection<Product_Incredient> Products { get; set; } = [];
    }
}
