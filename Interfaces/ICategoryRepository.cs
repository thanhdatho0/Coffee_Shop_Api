using Coffee_Shop_Api.DTOs.CategoryDTOs;

namespace Coffee_Shop_Api.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<CategoryDto>> GetAllAsync();
        Task<CategoryDto?> GetById(int id);
        Task<CategoryDto> CreateAsync(CategoryCreateDto categoryCreateDto);
        Task<CategoryDto?> UpdateAsync(int id, CategoryUpdateDto categoryUpdateDto);
    }
}
