using Microsoft.Extensions.DependencyInjection;

namespace BoundedContext2
{
    public static class ConfigureServices
    {
        public static void AddBoundedContext2(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BoundedContext2DbContext>();
        }
    }
}
