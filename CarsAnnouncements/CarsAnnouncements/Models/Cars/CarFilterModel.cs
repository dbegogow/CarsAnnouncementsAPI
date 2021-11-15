namespace CarsAnnouncements.Models.Cars
{
    public class CarFilterModel
    {
        public string Brand { get; init; }

        public string Model { get; init; }

        public string Type { get; init; }

        public string Fuel { get; init; }

        public string Transmission { get; init; }

        public int? Price { get; init; }

        public int? Year { get; init; }

        public int? Doors { get; init; }

        public int? Horsepower { get; init; }
    }
}
