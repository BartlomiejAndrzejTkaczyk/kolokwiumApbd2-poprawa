using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult test()
        {
            var e =new Exception("AAAA");
            e.Data["CodeStatus"] = 303;
            throw e;
            
        }
    }
}