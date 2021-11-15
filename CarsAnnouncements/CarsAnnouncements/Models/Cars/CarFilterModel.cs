namespace CarsAnnouncements.Models.Cars
{
    public class CarFilterModel
    {
        public string Brand { get; init; }

        public string Model { get; init; }

        public string Type { get; init; }

        public string Fuel { get; init; }

        public string Transmission { get; init; }

        public int? FromPrice { get; init; }

        public int? ToPrice { get; init; }

        public int? FromYear { get; init; }

        public int? ToYear { get; init; }

        public int? Doors { get; init; }

        public int? FromHorsepower { get; init; }

        public int? ToHorsepower { get; init; }
    }
}
