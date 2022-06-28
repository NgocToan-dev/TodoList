using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using UserServiceAPI.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserServiceAPI.Controllers
{
    [Route("v1/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService = null;

        public UserController()
        {
            _userService = new UserService();
        }


        // GET api/<TodoListController>/5
        [HttpGet("{userID}")]
        public IActionResult GetUserByID(int userID)
        {
            ServiceResult result = _userService.GetUserByID(userID);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Login([FromBody] string email)
        {
            ServiceResult result = _userService.Login(email);
            return Ok(result);
        }

    }
}
