using Coffee_Shop_Api.DTOs.EmployeeDTOs;
using Coffee_Shop_Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeRepository employeeRepo) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);  
            return Ok(await employeeRepo.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var employee = await employeeRepo.GetByIdAsync(id);
            return employee != null ? Ok(employee) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] EmployeeCreateDto employeeCreateDto)
        {
            if(!ModelState.IsValid) return BadRequest();
            try
            {
                var newEmployee = await employeeRepo.CreateAsync(employeeCreateDto);
                return Ok(newEmployee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromForm] EmployeeUpdateDto employeeUpdateDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var employee = await employeeRepo.UpdateAsync(id, employeeUpdateDto);
                return employee == null ? NotFound() : Ok(employee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
