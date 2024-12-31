namespace Coffee_Shop_Api.DTOs.IncredientDTOs
{
    public class IngredientUpdateDto
    {
        public required string IncredientName { get; set; }
        public decimal? ImportedQuantity { get; set; }
        public string? Unit { get; set; }
        public decimal? Cost { get; set; }
        public DateTime ImportedDate { get; set; } = DateTime.UtcNow;
    }
}
