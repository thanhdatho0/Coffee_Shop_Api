using Coffee_Shop_Api.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_Api.DTOs.EmployeeDTOs
{
    public class EmployeeCreateDto
    {
        [StringLength(50)]
        public required string EmployeeName { get; set; }
        [StringLength(11)]
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
