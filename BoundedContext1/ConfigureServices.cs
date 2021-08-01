using Microsoft.Extensions.DependencyInjection;

namespace BoundedContext1
{
    public static class ConfigureServices
    {
        public static void AddBoundedContext1(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BoundedContext1DbContext>();
        }
    }
}
