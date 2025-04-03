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
                await context.Response.WriteAsync("AoA Pakistan...");
                await next();
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("AoA Pakistan again...");
                await next();
            });

            app.Run();
        }
    }
}
