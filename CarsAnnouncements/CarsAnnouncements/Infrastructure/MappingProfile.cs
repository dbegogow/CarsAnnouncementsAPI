using AutoMapper;
using CarsAnnouncements.Data.Models;
using CarsAnnouncements.Services.Cars.Models;
using CarsAnnouncements.Services.Brands.Models;

namespace CarsAnnouncements.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, BrandServiceModel>();

            CreateMap<Car, CarCardServiceModel>();
        }
    }
}
