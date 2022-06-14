using LondonStock.Models;
using LondonStock.Service;
using Microsoft.EntityFrameworkCore;

namespace LondonStock
{
    // TODO: swagger specs
    // TODO: Logging sirilog/nlog
    // TODO: Containerization and automated builds using JenkinsFile & DockerFile
    // TODO: More document style and comments :)
    // TODO: Autoscaling of pods based upon cpu/memory threshold if containerised
    // TODO: Azure functions (AWS Lambda, API gateway) if serverless
    // TODO: Some caching, appsettings (wherever/if applicable)

    public static class Startup
    {
        public static WebApplication InitializeApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }

        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddSingleton<ILondonStockService, LondonStockService>();
            builder.Services.AddDbContext<StocksContext>(opt =>
                opt.UseInMemoryDatabase("Stocks"));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }

        private static void Configure(WebApplication app)
        {

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthorization();

            app.MapControllers();

        }
    }
}
