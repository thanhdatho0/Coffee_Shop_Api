using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }
    }
}
