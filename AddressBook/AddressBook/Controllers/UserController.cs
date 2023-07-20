using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using DomainLayer.Models;
namespace WebAPILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _User { get; }
        public UserController(IUserService user)
        {
            this._User = user;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAll()
        {
            return Ok(this._User.GetAll());
        }
        [HttpGet("GetUser")]
        public IActionResult GetById(string Id)
        {
            return Ok(this._User.GetById(Id));
        }
        [HttpPost("AddUser")]
        public IActionResult AddUser(User user)
        {
            return Ok(this._User.AddUser(user));
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            return Ok(this._User.UpdateUser(user));
        }
        [HttpDelete("DeleteUser/{Id}")]
        public IActionResult DeleteUser(string Id)
        {
            return Ok(this._User.DeleteUser(Id));
        }
    }
}
