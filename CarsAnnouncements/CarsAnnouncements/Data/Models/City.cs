using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static CarsAnnouncements.Data.DataConstants;

namespace CarsAnnouncements.Data.Models
{
    public class City
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public ICollection<Company> Companies { get; init; } = new HashSet<Company>();
    }
}
