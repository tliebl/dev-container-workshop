using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WorkshopAPI.Database;
using WorkshopAPI.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var services = builder.Services;
var host = builder.Host;

// Add configuration sources
configuration.AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true);
configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
configuration.AddJsonFile("Secrets/appsettings.secrets.json", optional: true, reloadOnChange: true);
configuration.AddEnvironmentVariables();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    });
services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://127.0.0.1:5026", "http://localhost:5026", "http://localhost:8090", "http://localhost:5056") // Add your Blazor app's origin here
        .AllowAnyMethod()
        .AllowAnyHeader());
});

// Add the database context
services.AddDbContext<WorkshopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WorkshopDatabase")));
// register repositories in the DI container
services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    // Enable middleware to serve swagger-ui
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}
// Use the CORS policy
app.UseCors("AllowSpecificOrigin");
app.MapControllers();
app.UseHttpsRedirection();
app.Run();
