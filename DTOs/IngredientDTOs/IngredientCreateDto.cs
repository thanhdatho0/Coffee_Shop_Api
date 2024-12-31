using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.IncredientDTOs
{
    public class IngredientCreateDto
    {
        public required string IncredientName { get; set; }
        public required string Unit { get; set; }
        public DateTime ImportedDate { get; set; } = DateTime.UtcNow;
    }
}
