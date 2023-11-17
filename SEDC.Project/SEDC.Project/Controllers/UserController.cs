using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.Project.Domain.Models;
using SEDC.Project.DTOS.Users;
using SEDC.Project.Services.Interfaces;

namespace SEDC.Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<UsersDto> Get(int id)
        {
            return Ok(_userService.GetUser(id));
        }
    }
}
