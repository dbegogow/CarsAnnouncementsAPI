using Microsoft.AspNetCore.Mvc;

namespace CarsAnnouncements.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
