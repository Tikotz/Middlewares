using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddlewere.CustomMiddleweres
{
    public class MapClassMiddlewere : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await next(context);
        }
    }
}
