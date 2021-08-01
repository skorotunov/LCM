using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace BoundedContext1
{
    public static class Endpoints
    {
        public static void MapBoundedContext1(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/boundedcontext1", async context =>
            {
                await context.Response.WriteAsync("context 1");
            });
        }
    }
}
