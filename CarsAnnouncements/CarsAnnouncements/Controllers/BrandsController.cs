using Microsoft.AspNetCore.Mvc;
using CarsAnnouncements.Services.Brands;

namespace CarsAnnouncements.Controllers
{
    [Route("api/brands")]
    [ApiController]
    public class BrandsController : ControllerBase

    {
        private readonly IBrandsService _brands;

        public BrandsController(IBrandsService brands)
            => this._brands = brands;

        [HttpGet]
        public IActionResult Get()
        {
            var brands = this._brands.All();

            return Ok(brands);
        }
    }
}
