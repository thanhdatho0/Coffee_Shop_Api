using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.CategoryDTOs
{
    public class CategoryCreateDto
    {
        [DefaultValue("")]
        public required string CategoryName { get; set; }
    }
}
