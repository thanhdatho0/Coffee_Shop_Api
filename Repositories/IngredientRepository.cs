using Coffee_Shop_Api.Data;
using Coffee_Shop_Api.DTOs.IncredientDTOs;
using Coffee_Shop_Api.Interfaces;
using Coffee_Shop_Api.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_Api.Repositories
{
    public class IngredientRepository(ApplicationDBContext db) : IIngredientRepository
    {
        public async Task<IngredientDto> CreateAsync(IngredientCreateDto ingredientCreateDto)
        {
            var ingredient = ingredientCreateDto.ToIngredientFromCreateDto();
            await db.Incredients.AddAsync(ingredient);
            await db.SaveChangesAsync();
            return ingredient.ToIngredientDto();
        }

        public async Task<List<IngredientDto>> GetAllAsync()
        {
            return await db.Incredients.Select(i => i.ToIngredientDto()).AsNoTracking().ToListAsync();
        }

        public async Task<IngredientDetailsByIdDto?> GetByIdAsync(int id)
        {
            var ingredientById = await db.Incredients
                .Select(i => i.ToIngredientDto())
                .FirstOrDefaultAsync(i => i.IncredientId == id);
            
            var ingredientDetails = await db.IncredientDetails
                .Where(i => i.IncredientId == id)
                .Select(i => i.ToIngredientDetailDto())
                .ToListAsync();
            return new IngredientDetailsByIdDto
            {
                IncredientDto = ingredientById!,
                IngredientDetails = ingredientDetails
            };
        }

        public Task<IngredientDto?> UpdateAsync(int id, IngredientUpdateDto ingredientUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
