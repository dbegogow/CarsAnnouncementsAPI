using AutoMapper;
using System.Linq;
using CarsAnnouncements.Data;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using CarsAnnouncements.Services.Brands.Models;

namespace CarsAnnouncements.Services.Brands
{
    public class BrandsService : IBrandsService
    {
        private readonly CarsAnnouncementsDbContext _data;
        private readonly IConfigurationProvider _mapper;

        public BrandsService(CarsAnnouncementsDbContext data, IMapper mapper)
        {
            this._data = data;
            this._mapper = mapper.ConfigurationProvider;
        }

        public IEnumerable<BrandFilterServiceModel> All()
            => this._data
                .Brands
                .ProjectTo<BrandFilterServiceModel>(this._mapper)
                .ToList();
    }
}
