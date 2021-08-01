using Microsoft.EntityFrameworkCore;

namespace BoundedContext1
{
    public class BoundedContext1DbContext : DbContext
    {
        public DbSet<Entity1> Entities1 { get; set; }
    }
}
