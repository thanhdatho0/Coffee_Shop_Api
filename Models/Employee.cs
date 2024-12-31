using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_Api.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [StringLength(50)]
        public required string EmployeeName { get; set; }
        [StringLength(11)]
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateOnly StartDate { get; set; }
        public bool Status { get; set; }
        public ICollection<Order> Orders { get; set; } = [];
    }
}
