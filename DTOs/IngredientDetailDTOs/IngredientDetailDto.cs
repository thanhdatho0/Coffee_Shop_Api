using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.IncredientDetailDTOs
{
    public class IngredientDetailDto
    {
        public DateTime ImportedDate { get; set; }
        public decimal ImportedQuantity { get; set; }
        public decimal Cost { get; set; }
    }
}
