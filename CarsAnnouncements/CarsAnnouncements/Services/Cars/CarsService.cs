using AutoMapper;
using System.Linq;
using CarsAnnouncements.Data;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using CarsAnnouncements.Services.Cars.Models;

namespace CarsAnnouncements.Services.Cars
{
    public class CarsService : ICarsService
    {
        private readonly CarsAnnouncementsDbContext _data;
        private readonly IConfigurationProvider _mapper;

        public CarsService(CarsAnnouncementsDbContext data, IMapper mapper)
        {
            this._data = data;
            this._mapper = mapper.ConfigurationProvider;
        }

        public IEnumerable<CarCardServiceModel> All(
            string brand = null,
            string model = null,
            string type = null,
            string fuel = null,
            string transmission = null,
            int? fromPrice = null,
            int? toPrice = null,
            int? fromYear = null,
            int? toYear = null,
            int? doors = null,
            int? fromHorsepower = null,
            int? toHorsepower = null)
        {
            var carsQuery = this._data
                .Cars
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(brand))
            {
                carsQuery = carsQuery
                    .Where(c => c.Brand.Name == brand);
            }

            if (!string.IsNullOrWhiteSpace(model))
            {
                carsQuery = carsQuery
                    .Where(c => c.Model.Name == model);
            }

            if (!string.IsNullOrWhiteSpace(type))
            {
                carsQuery = carsQuery
                    .Where(c => c.Type.Name == type);
            }

            if (!string.IsNullOrWhiteSpace(fuel))
            {
                carsQuery = carsQuery
                    .Where(c => c.Fuel.Name == fuel);
            }

            if (!string.IsNullOrWhiteSpace(transmission))
            {
                carsQuery = carsQuery
                    .Where(c => c.Transmission.Name == transmission);
            }

            if (fromPrice != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Price >= fromPrice);
            }

            if (toPrice != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Price <= toPrice);
            }

            if (fromYear != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Year >= fromYear);
            }

            if (toYear != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Year <= toYear);
            }

            if (doors != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Doors == doors);
            }

            if (fromHorsepower != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Horsepower >= fromHorsepower);
            }

            if (toHorsepower != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Horsepower <= toHorsepower);
            }


            var cars = carsQuery
                .ProjectTo<CarCardServiceModel>(this._mapper)
                .ToList();

            return cars;
        }
    }
}
