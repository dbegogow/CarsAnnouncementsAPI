using System;
using System.ComponentModel.DataAnnotations;

using static CarsAnnouncements.Data.DataConstants;

namespace CarsAnnouncements.Data.Models
{
    public class Company
    {

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public string Address { get; set; }

        public string Image { get; set; }

        [Required]
        public string DealerId { get; set; }

        public Dealer Dealer { get; set; }
    }
}
