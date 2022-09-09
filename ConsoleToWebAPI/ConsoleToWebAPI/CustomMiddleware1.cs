using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleToWebAPI
{
    public class CustomMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from c-mid-2-1 \n");
            await next(context);
            await context.Response.WriteAsync("Hello from c-mid-2-2 extended\n");
        }
    }
}
