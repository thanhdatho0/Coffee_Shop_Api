using Coffee_Shop_Api.DTOs.IncredientDTOs;
using Coffee_Shop_Api.Models;

namespace Coffee_Shop_Api.Mappers
{
    public static class IngredientMappers
    {
        public static IngredientDto ToIngredientDto(this Ingredient ingredient)
        {
            return new IngredientDto
            {
                IncredientId = ingredient.IncredientId,
                IncredientName = ingredient.IncredientName,
                InStock = ingredient.InStock,
                Unit = ingredient.Unit,
                LastImportedDate = ingredient.LastImportedDate,
            };
        }

        public static Ingredient ToIngredientFromCreateDto(this IngredientCreateDto ingredientCreateDto)
        {
            return new Ingredient
            {
                IncredientName = ingredientCreateDto.IncredientName,
                Unit = ingredientCreateDto.Unit,
            };
        }

    }
}
