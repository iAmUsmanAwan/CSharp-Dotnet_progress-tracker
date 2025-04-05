using System.Security.Cryptography.X509Certificates;
using Lecture55;

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
                    await context.Response.WriteAsync("AoA Pakistan... \n");
                    await next();      // in order to call the next middleware
                
            });

            app.Use(async (context, next) =>
            {
                if(context.Request.Path == "/short")
                {
                    await context.Response.WriteAsync("AoA Pakistan again... \n");
                }
                else
                {
                    await next();
                }
    
            });

            app.UseMiddleware<MyMiddleware>();
            app.UseMiddleware<MySecondMiddleware>();


            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("AoA Pakistan again and again... \n");
            });

            app.Run();
        }
    }
}