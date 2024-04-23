using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;

namespace HelloWorld
{
    public class Function : IHttpFunction
    {
        public async Task HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsync("Hello World!");
        }
    }
}