using Coffee_Shop_Api.Data;
using Coffee_Shop_Api.DTOs.CategoryDTOs;
using Coffee_Shop_Api.Interfaces;
using Coffee_Shop_Api.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_Api.Repositories
{
    public class CategoryRepository(ApplicationDBContext db) : ICategoryRepository
    {
        public async Task<CategoryDto> CreateAsync(CategoryCreateDto categoryCreateDto)
        {
            var categoryModel = categoryCreateDto.ToCategoryFromCreateDto();
            await db.Categories.AddAsync(categoryModel);
            await db.SaveChangesAsync();
            return categoryModel.ToCategoryDto();
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            return await db.Categories.Select(c => c.ToCategoryDto()).AsNoTracking().ToListAsync();
        }

        public async Task<CategoryDto?> GetById(int id)
        {
            var category = await db.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
            return category?.ToCategoryDto();
        }

        public async Task<CategoryDto?> UpdateAsync(int id, CategoryUpdateDto categoryUpdateDto)
        {
            var category = await db.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
            if (category == null) return null;
            category.ToCategoryFromUpdateDto(categoryUpdateDto);
            await db.SaveChangesAsync();
            return category.ToCategoryDto();
        }
    }
}
