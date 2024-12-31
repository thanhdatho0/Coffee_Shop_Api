using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_Api.Models
{
    public class Image
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public required string Url { get; set; }
        public string? Alt { get; set; }
    }
}
