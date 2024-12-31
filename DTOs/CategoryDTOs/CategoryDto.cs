using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.CategoryDTOs
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        [DefaultValue("")]
        public string CategoryName { get; set; } = string.Empty;
    }
}
