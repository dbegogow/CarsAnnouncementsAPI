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
            int? priceFrom = null,
            int? priceTo = null,
            int? yearFrom = null,
            int? yearTo = null,
            int? doors = null,
            int? horsepowerFrom = null,
            int? horsePowerTo = null)
        {
            var carsQuery = this._data
                .Cars
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(brand))
            {
                carsQuery = carsQuery
                    .Where(c => c.Brand.Name == brand);
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                carsQuery = carsQuery
                    .Where(c => c.Model.Name == model);
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                carsQuery = carsQuery
                    .Where(c => c.Type.Name == type);
            }

            if (string.IsNullOrWhiteSpace(fuel))
            {
                carsQuery = carsQuery
                    .Where(c => c.Fuel.Name == fuel);
            }

            if (string.IsNullOrWhiteSpace(transmission))
            {
                carsQuery = carsQuery
                    .Where(c => c.Transmission.Name == transmission);
            }

            if (priceFrom != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Price >= priceFrom);
            }

            if (priceTo != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Price <= priceTo);
            }

            if (yearFrom != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Year >= yearFrom);
            }

            if (yearTo != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Year <= yearTo);
            }

            if (doors != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Doors == doors);
            }

            if (horsepowerFrom != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Horsepower >= horsepowerFrom);
            }

            if (horsePowerTo != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Horsepower <= horsePowerTo);
            }


            var cars = carsQuery
                .ProjectTo<CarCardServiceModel>(this._mapper)
                .ToList();

            return cars;
        }
    }
}
