using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NotificationService.Controllers
{
    [Route("v1/Notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {

        // GET api/<NotificationController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(1);
        }
    }
}
