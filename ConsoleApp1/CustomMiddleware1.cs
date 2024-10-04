using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("hello from new file - 1 \n");

            await next(context);

            await context.Response.WriteAsync("hello from new file - 2 \n");
        }
    }
}
