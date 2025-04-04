using System.Security.Cryptography.X509Certificates;

namespace Lecture54_Middleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Use(async (context, next) =>
            {
                var s = context.Request.Query["someData"];
                if(s.Equals("a"))     // now we have to pass the subquery ?somedata=a to get the below result
                {
                    await context.Response.WriteAsync("AoA Pakistan... \n");
                }

                await next();      // in order to call the next middleware
                await context.Response.WriteAsync("After the next() from the 1st Middleware... \n");

            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("AoA Pakistan again... \n");
                await next();
                await context.Response.WriteAsync("After the next() from the 2nd Middleware... \n");

            });

            app.Run(async (context) => 
            {
                await context.Response.WriteAsync("AoA Pakistan again and again... \n");
            });

            app.Run();
        }
    }
}
