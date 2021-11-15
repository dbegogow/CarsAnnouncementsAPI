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
            int? priceFrom = null,
            int? priceTo = null,
            int? yearFrom = null,
            int? yearTo = null,
            int? doors = null,
            int? horsepowerFrom = null,
            int? horsepowerTo = null
        );
    }
}
