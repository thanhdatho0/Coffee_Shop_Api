using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.CategoryDTOs
{
    public class CategoryUpdateDto
    {
        [DefaultValue("")]
        public required string CategoryName { get; set; }
    }
}
