using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static CarsAnnouncements.Data.DataConstants;

namespace CarsAnnouncements.Data.Models
{
    public class User
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public string CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<Car> Cars { get; init; } = new HashSet<Car>();
    }
}
