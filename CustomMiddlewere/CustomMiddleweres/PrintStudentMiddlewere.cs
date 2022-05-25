using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddlewere.CustomMiddleweres
{
    public class PrintStudentMiddlewere : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync($"Student number : {54}");
            
            await next(context);
        }
    }
}
