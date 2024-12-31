using Coffee_Shop_Api.DTOs.EmployeeDTOs;
using Coffee_Shop_Api.Models;

namespace Coffee_Shop_Api.Mappers
{
    public static class EmployeeMappers
    {
        public static EmployeeDto ToEmployeeDto(this Employee employee)
        {
            return new EmployeeDto
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                PhoneNumber = employee.PhoneNumber,
                Status = employee.Status,
            };
        }

        public static Employee ToEmployeeFromCreateDto(this EmployeeCreateDto employeeCreateDto)
        {
            return new Employee
            {
                EmployeeName = employeeCreateDto.EmployeeName,
                PhoneNumber = employeeCreateDto.PhoneNumber,
                Address = employeeCreateDto.Address,
                BirthDate = employeeCreateDto.BirthDate,
            };
        }

        public static void ToEmployeeFromUpdateDto(this Employee employee ,EmployeeUpdateDto employeeUpdateDto)
        {
            employee.EmployeeName = employeeUpdateDto.EmployeeName;
            employee.PhoneNumber = employeeUpdateDto.PhoneNumber;
            employee.Address = employeeUpdateDto.Address;
            employee.BirthDate = employeeUpdateDto.BirthDate;
            employee.Status = employeeUpdateDto.Status;
        }
    }
}
