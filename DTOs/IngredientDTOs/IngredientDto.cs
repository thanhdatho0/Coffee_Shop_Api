using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.IncredientDTOs
{
    public class IngredientDto
    {
        public int IncredientId { get; set; }
        [DefaultValue("")]
        public string IncredientName { get; set; } = string.Empty;
        public decimal InStock { get; set; }
        public string Unit { get; set; } = string.Empty;
        public DateTime LastImportedDate { get; set; }
    }
}
