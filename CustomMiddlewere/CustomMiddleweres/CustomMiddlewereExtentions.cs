using Microsoft.AspNetCore.Builder;

namespace CustomMiddlewere.CustomMiddleweres
{
    
        public static class CustomMiddlewareExtensions
        {

            public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
            {
                return builder.UseMiddleware<PrintClassMiddlewere>();
            }

        }

    
}
