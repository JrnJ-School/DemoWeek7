using Microsoft.EntityFrameworkCore;

namespace DemoWeek7.Models
{
    public class DomainContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }

        public DomainContext(DbContextOptions<DomainContext> options)
            : base(options)
        {

        }
    }
}
