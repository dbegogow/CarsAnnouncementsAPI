using System.Collections.Generic;

namespace CarsAnnouncements.Data.Models
{
    public class Transmission
    {
        public int Id { get; init; }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; init; } = new HashSet<Car>();
    }
}
