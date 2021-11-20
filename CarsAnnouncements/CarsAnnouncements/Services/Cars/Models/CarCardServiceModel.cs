namespace CarsAnnouncements.Services.Cars.Models
{
    public class CarCardServiceModel
    {
        public int Id { get; init; }

        public string BrandName { get; init; }

        public string ModelName { get; init; }

        public string TypeName { get; init; }

        public string FuelName { get; init; }

        public string TransmissionName { get; init; }

        public int Price { get; init; }

        public int Year { get; init; }

        public string Doors { get; init; }

        public int Horsepower { get; init; }
    }
}
