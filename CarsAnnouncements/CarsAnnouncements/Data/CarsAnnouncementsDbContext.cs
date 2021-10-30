using Microsoft.EntityFrameworkCore;

namespace CarsAnnouncements.Data
{
    public class CarsAnnouncementsDbContext : DbContext
    {
        public CarsAnnouncementsDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
