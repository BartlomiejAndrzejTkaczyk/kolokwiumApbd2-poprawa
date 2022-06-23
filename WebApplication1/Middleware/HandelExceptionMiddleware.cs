using Microsoft.AspNetCore.Diagnostics;

namespace WebApplication1.Middleware
{
    public class HandelExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public HandelExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var exception = context.Features
            .Get<IExceptionHandlerPathFeature>()
            .Error;
            var response = new { error = exception.Message };
            context.Response.HttpContext.Response.StatusCode = (int)exception.Data["CodeStatus"];
            await _next(context);
        }
    }
}
