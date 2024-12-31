using Coffee_Shop_Api.Data;
using Coffee_Shop_Api.DTOs.EmployeeDTOs;
using Coffee_Shop_Api.Interfaces;
using Coffee_Shop_Api.Mappers;
using Coffee_Shop_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_Api.Repositories
{
    public class EmployeeRepository(ApplicationDBContext db) : IEmployeeRepository
    {
        public async Task<EmployeeDto> CreateAsync(EmployeeCreateDto employee)
        {
            var employeeModel = employee.ToEmployeeFromCreateDto();
            employeeModel.StartDate = DateOnly.FromDateTime(DateTime.UtcNow);
            employeeModel.Status = true;
            await db.Employees.AddAsync(employeeModel);
            await db.SaveChangesAsync();
            return employeeModel.ToEmployeeDto();
        }

        public async Task<List<EmployeeDto>> GetAllAsync()
        {
            return await db.Employees
                .Select(e => e.ToEmployeeDto())
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
        }

        public async Task<EmployeeDto?> UpdateAsync(int id, EmployeeUpdateDto employee)
        {
            var employeeModel = await db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
            if (employeeModel == null) return null;
            employeeModel.ToEmployeeFromUpdateDto(employee);
            await db.SaveChangesAsync();
            return employeeModel.ToEmployeeDto();
        }
    }
}
