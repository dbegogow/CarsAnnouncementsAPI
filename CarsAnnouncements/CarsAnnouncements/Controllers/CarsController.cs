using Microsoft.AspNetCore.Mvc;
using CarsAnnouncements.Models.Cars;
using CarsAnnouncements.Services.Cars;

namespace CarsAnnouncements.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsService _cars;

        public CarsController(ICarsService cars)
            => this._cars = cars;

        [HttpPost]
        public IActionResult AllCards(CarFilterModel model)
        {
            var cars = this._cars
                .All(
                    model.Brand,
                    model.Model,
                    model.Type,
                    model.Fuel,
                    model.Transmission,
                    model.FromPrice,
                    model.ToPrice,
                    model.FromYear,
                    model.ToYear,
                    model.Doors,
                        model.FromHorsepower,
                    model.ToHorsepower
                );

            return Ok(cars);
        }
    }
}
