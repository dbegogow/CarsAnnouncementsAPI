using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static CarsAnnouncements.Data.DataConstants;

namespace CarsAnnouncements.Data.Models
{
    public class Brand
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public ICollection<Model> Models { get; init; } = new HashSet<Model>();

        public ICollection<Car> Cars { get; init; } = new HashSet<Car>();
    }
}
