using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace BoundedContext2
{
    public static class Endpoints
    {
        public static void MapBoundedContext2(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/boundedcontext2", async context =>
            {
                await context.Response.WriteAsync("context 2");
            });
        }
    }
}
