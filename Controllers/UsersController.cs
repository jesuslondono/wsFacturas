using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using wsFacturas.Models;
using wsFacturas.Services;

namespace wsFacturas.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Usuario o contraseña incorrecto" });

            return Ok(response);
        }

        
        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
