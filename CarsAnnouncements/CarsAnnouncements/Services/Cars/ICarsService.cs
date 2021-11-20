using System.Collections.Generic;
using CarsAnnouncements.Services.Cars.Models;

namespace CarsAnnouncements.Services.Cars
{
    public interface ICarsService
    {
        IEnumerable<CarCardServiceModel> All(
            string brand = null,
            string model = null,
            string type = null,
            string fuel = null,
            string transmission = null,
            int? fromPrice = null,
            int? toPrice = null,
            int? fromYear = null,
            int? toYear = null,
            string doors = null,
            int? fromHorsepower = null,
            int? toHorsepower = null
            );
    }
}
