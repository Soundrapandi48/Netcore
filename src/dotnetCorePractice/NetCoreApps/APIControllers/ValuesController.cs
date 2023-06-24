using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreApps.Model;

namespace NetCoreApps.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("{id}")]
        [HttpGet]
        public IActionResult Testing( int id)
        {
            int k = id;
            return Ok();
        }
        [HttpGet]
        public string Get()
        {
            return "TestAPI";
        }
        [Route("Putting/{id}")]
        [HttpPut]
        public IActionResult Test( int k,[FromBody] User user)
        {
            return Ok();
        }
    }
}
