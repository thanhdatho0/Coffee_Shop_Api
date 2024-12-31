using Coffee_Shop_Api.DTOs.IncredientDetailDTOs;
using Coffee_Shop_Api.DTOs.IncredientDTOs;
using Coffee_Shop_Api.Models;

namespace Coffee_Shop_Api.Mappers
{
    public static class IngredientDetailMappers
    {
        public static IngredientDetailDto ToIngredientDetailDto(this IngredientDetail ingredientDetail)
        {
            return new IngredientDetailDto
            {
                ImportedDate = ingredientDetail.ImportedDate,
                ImportedQuantity = ingredientDetail.ImportedQuantity,
                Cost = ingredientDetail.Cost,
            };
        }
    }
}
