using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static CarsAnnouncements.Data.DataConstants;

namespace CarsAnnouncements.Data.Models
{
    public class Type
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public ICollection<Car> Cars { get; init; } = new HashSet<Car>();
    }
}
