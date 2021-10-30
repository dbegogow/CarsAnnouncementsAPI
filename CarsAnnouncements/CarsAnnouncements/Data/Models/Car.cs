using System.ComponentModel.DataAnnotations;

using static CarsAnnouncements.Data.DataConstants;

namespace CarsAnnouncements.Data.Models
{
    public class Car
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Model { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int FuelId { get; set; }

        public Fuel Fuel { get; set; }

        public int TransmissionId { get; set; }

        public Transmission Transmission { get; set; }

        public int Price { get; set; }

        public int Year { get; set; }

        public int Doors { get; set; }

        public int Horsepower { get; set; }
    }
}
