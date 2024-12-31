using Coffee_Shop_Api.DTOs.IncredientDetailDTOs;

namespace Coffee_Shop_Api.DTOs.IncredientDTOs
{
    public class IngredientDetailsByIdDto
    {
        public required IngredientDto IncredientDto { get; set; }
        public ICollection<IngredientDetailDTO> IngredientDetails { get; set; } = [];
    }
}
