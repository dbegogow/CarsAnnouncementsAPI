using AutoMapper;
using CarsAnnouncements.Data.Models;
using CarsAnnouncements.Services.Brands.Models;

namespace CarsAnnouncements.Services.Profiles
{
    public class BrandsProfile : Profile
    {
        public BrandsProfile()
        {
            CreateMap<Brand, BrandServiceModel>();
        }
    }
}
