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
            CreateMap<Profile, BrandServiceModel>();

            CreateMap<Car, CarCardServiceModel>();
        }
    }
}
