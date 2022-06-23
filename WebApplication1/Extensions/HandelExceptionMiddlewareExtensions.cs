using WebApplication1.Middleware;

namespace WebApplication1.Extensions
{
    public static class HandelExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseHandelExceptio(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HandelExceptionMiddleware>();
        }
    }
}
