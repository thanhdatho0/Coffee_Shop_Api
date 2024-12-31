using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_Api.Models
{
    public class Zone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZoneId { get; set; }
        public required string ZoneName { get; set; }
        public ICollection<Table> Tables { get; set; } = [];
    }
}
