using BookAPI.DataTransferObjects;
using BookAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _services;

        public UserController(IUserServices services)
        {
            this._services = services;
        }

        [HttpPost("Register")]
        public IActionResult AddUser([FromBody]UserRegisterDto userRegisterDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Invalid Credential");
            }
            var result = _services.Register(userRegisterDto);

            return Ok(result);
        }

        //[HttpPost("Login")]
        //public IActionResult Login([FromBody]UserRegisterDto userRegisterDto)
        //{
        //    var result = _services.Login(userRegisterDto);
        //    if (result == null)
        //    {
        //        return BadRequest("Cannot retrieve details");
        //    }
        //    return Ok(result);
        //}

        //[HttpGet("GetAll")]
        //public IActionResult GetAll()
        //{
        //    var result = _services.GetAll();
        //    if (result == null)
        //    {
        //        return BadRequest("Book List Is Empty");
        //    }
        //    return Ok(result);
        //}

        //[HttpGet("GetUserId")]
        //public IActionResult GetUserId(string userId)
        //{
        //    var result = _services.GetUserById(userId);
        //    if (result == null)
        //    {
        //        return BadRequest("ID not found");
        //    }
        //    return Ok(result);
        //}

        //[HttpGet("{id}")]
        //public IActionResult DeleteById(string id)
        //{
        //    var result = _services.DeleteUser(id);
        //    if (result == null)
        //    {
        //        return BadRequest("Id Not Found");
        //    }
        //    return Ok(result);
        //}
    }
}
