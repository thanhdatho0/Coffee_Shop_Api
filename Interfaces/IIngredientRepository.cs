using Coffee_Shop_Api.DTOs.IncredientDTOs;
using Coffee_Shop_Api.DTOs.ZoneDTOs;

namespace Coffee_Shop_Api.Interfaces
{
    public interface IIngredientRepository
    {
        Task<List<IngredientDto>> GetAllAsync();
        Task<IngredientDetailsByIdDto?> GetByIdAsync(int id);
        Task<IngredientDto> CreateAsync(IngredientCreateDto ingredientCreateDto);
        Task<IngredientDto?> UpdateAsync(int id, IngredientUpdateDto ingredientUpdateDto);
    }
}
