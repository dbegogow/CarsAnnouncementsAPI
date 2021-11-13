using System.Collections.Generic;
using CarsAnnouncements.Services.Brands.Models;

namespace CarsAnnouncements.Services.Brands
{
    public interface IBrandsService
    {
        IEnumerable<BrandServiceModel> All();
    }
}
