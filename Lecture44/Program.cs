namespace Lecture44
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();    // to use static files like css, js, images etc (from the folder wwwroot). we add these two lines of code 

            //app.MapGet("/", () => "Hello World!");    // opens a new window and print "Hello World!"

            app.Run();
        }
    }
}
