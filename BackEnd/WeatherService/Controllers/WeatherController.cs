using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using WeatherServiceAPI.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherServiceAPI.Controllers
{
    [Route("v1/Weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        WeatherService _weatherService = null;
        ServiceResult _serviceResult = null;
        public WeatherController()
        {
            _weatherService = new WeatherService();
            _serviceResult = new ServiceResult();
        }
        // GET api/<ValuesController>/5
        [HttpGet]
        public IActionResult GetWeather(string place)
        {
            _serviceResult = _weatherService.GetWeather(place);

            return Ok(_serviceResult);
        }

    }
}
