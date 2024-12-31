using Coffee_Shop_Api.DTOs.EmployeeDTOs;
using Coffee_Shop_Api.Models;

namespace Coffee_Shop_Api.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeDto>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);
        Task<EmployeeDto> CreateAsync(EmployeeCreateDto employee);
        Task<EmployeeDto?> UpdateAsync(int id, EmployeeUpdateDto employee);
    }
}
