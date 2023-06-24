using APIProject.Contracts;
using APIProject.Entities.DataTransferObjects;
using APIProject.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MnaufacturerController : ControllerBase
    {

        private readonly IManufacturer _manufacturer;
        public MnaufacturerController(IManufacturer manufacturer)
        {
            this._manufacturer = manufacturer;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ManufacturerDTO dto)
        {
            await _manufacturer.Create(dto);
            return Ok();
        }

        [HttpGet("{name}")]
        public async Task<ManufacturerDTO> Get(string name)
        {
          return  await _manufacturer.Get(name);
        }
        [HttpGet]
        public async Task<IEnumerable<ManufacturerDTO>> GetAll()
        {
            return await _manufacturer.GetAll();
        }
        [HttpDelete("{name}")]
        public async Task<IActionResult> Delete(string name)
        {
            await _manufacturer.Delete(name);

            return Ok();
        }
        [HttpPut("{name}")]
        public async Task<IActionResult> Update(string name,[FromBody] ManufacturerDTO manufacturer)
        {
            await _manufacturer.Update(name,manufacturer);

            return Ok();
        }

    }
}
