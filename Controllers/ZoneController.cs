using Coffee_Shop_Api.DTOs.ZoneDTOs;
using Coffee_Shop_Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoneController(IZoneRepository zoneRepo) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(await zoneRepo.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var zone = await zoneRepo.GetByIdAsync(id);
            return zone == null ? NotFound() : Ok(zone);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ZoneCreateDto zoneCreateDto)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                return Ok(await zoneRepo.CreateAsync(zoneCreateDto));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id,[FromForm] ZoneUpdateDto zoneUpdateDto)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var zone = await zoneRepo.UpdateAsync(id, zoneUpdateDto);
                return zone != null ? Ok(zone) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
