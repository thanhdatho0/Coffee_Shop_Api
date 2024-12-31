using Coffee_Shop_Api.DTOs.CategoryDTOs;
using Coffee_Shop_Api.Models;

namespace Coffee_Shop_Api.Mappers
{
    public static class CategoryMappers
    {
        public static CategoryDto ToCategoryDto(this Category category)
        {
            return new CategoryDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
            };
        }

        public static Category ToCategoryFromCreateDto(this CategoryCreateDto categoryCreateDto)
        {
            return new Category { CategoryName = categoryCreateDto.CategoryName };
        }

        public static void ToCategoryFromUpdateDto(this Category category, CategoryUpdateDto categoryUpdateDto)
        {
            category.CategoryName = categoryUpdateDto.CategoryName;
        }
    }
}
