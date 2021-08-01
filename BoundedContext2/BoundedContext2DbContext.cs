using Microsoft.EntityFrameworkCore;

namespace BoundedContext2
{
    public class BoundedContext2DbContext : DbContext
    {
        public DbSet<Entity1> Entities1 { get; set; }

        public DbSet<Entity2> Entities2 { get; set; }
    }
}
