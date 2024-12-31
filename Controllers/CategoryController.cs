using Coffee_Shop_Api.DTOs.CategoryDTOs;
using Coffee_Shop_Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryRepository categoryRepo) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(await categoryRepo.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var category = await categoryRepo.GetById(id);
            return category == null ? NotFound() : Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CategoryCreateDto categoryCreateDto)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                return Ok(await categoryRepo.CreateAsync(categoryCreateDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id,[FromForm] CategoryUpdateDto categoryUpdateDto)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var category = await categoryRepo.UpdateAsync(id, categoryUpdateDto);
                return category != null ? Ok(category) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
