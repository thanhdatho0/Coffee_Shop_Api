using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_Api.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime ExportDate { get; set; } = DateTime.Now;
        public bool OrderType { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int? TableId { get; set; }
        public Table? Table { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = [];
    }
}
