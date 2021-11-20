using System;
using System.ComponentModel.DataAnnotations;

namespace CarsAnnouncements.Data.Models
{
    public class Car
    {
        public int Id { get; init; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int ModelId { get; set; }

        public Model Model { get; set; }

        public int TypeId { get; set; }

        public Type Type { get; set; }

        public int FuelId { get; set; }

        public Fuel Fuel { get; set; }

        public int TransmissionId { get; set; }

        public Transmission Transmission { get; set; }

        public int Price { get; set; }

        public int Year { get; set; }

        [Required]
        public string Doors { get; set; }

        public int Horsepower { get; set; }

        public int Kilometers { get; set; }

        public int Cubes { get; set; }

        public string Description { get; set; }

        public string Extras { get; set; }

        public int Views { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
