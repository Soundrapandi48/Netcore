using APIProject.Contracts;
using APIProject.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserData _Userdetails;
        public UserController(IUserData userData)
        {
            _Userdetails = userData;
        }
        

        [HttpGet]
        public async Task<UserData> SearchAll(Guid Id)
        {
            return await _Userdetails.GetUser(Id);
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] UserData userData)
        {
            await _Userdetails.CreateUser(userData);
            return Ok();
        }
    }
}
