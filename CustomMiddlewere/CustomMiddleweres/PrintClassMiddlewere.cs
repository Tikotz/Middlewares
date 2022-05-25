using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddlewere.CustomMiddleweres
{
    public class PrintClassMiddlewere : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync($"Class Number : {3}");
            
            await next(context);
        }
    }
}
