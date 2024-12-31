using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_Api.Models
{
    public class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TableId { get; set; }
        public int ZoneId { get; set; }
        public Zone? Zone { get; set; }
        public required string TableName { get; set; }
        [Range(0, 2)]
        public int Status { get; set; }
        public ICollection<Order> Orders { get; set; } = [];
    }
}
