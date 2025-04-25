namespace Lecture55
{
    public class MySecondMiddleware
    {
        private RequestDelegate next;
        public MySecondMiddleware(RequestDelegate nextDelegate)
        {
            this.next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Query["custom"].Equals("true"))
            {
                await context.Response.WriteAsync("I am second Classbased Middleware... \n");
            }
            await next(context);
        }

    }
}
