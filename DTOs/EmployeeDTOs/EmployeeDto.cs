using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.EmployeeDTOs
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        [DefaultValue("")]
        public string EmployeeName { get; set; } = string.Empty;
        [DefaultValue("")]
        public string PhoneNumber { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
