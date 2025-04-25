using Microsoft.AspNetCore.Http;
namespace Lecture55
{
    public class MyMiddleware
    {
        private RequestDelegate next;
        public MyMiddleware(RequestDelegate nextDelegate)
        {
            this.next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("I am Classbased Middleware... \n");
            await next(context);
        }


    }
}
