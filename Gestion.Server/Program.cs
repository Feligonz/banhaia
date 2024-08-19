using Microsoft.Extensions.Configuration;
using Gestion.Logic.Extensions;
using System.Globalization;

namespace Gestion.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var cultureInfo = new CultureInfo("es-AR");

            //CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            //CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            ConfigurationManager configuration = builder.Configuration;

            builder.Services.AddLogicServices(configuration.GetConnectionString("DefaultConnection"));

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
