using Microsoft.EntityFrameworkCore;
using WorkshopAPI.Database.Entities;

namespace WorkshopAPI.Database;
public class WorkshopContext : DbContext, IWorkshopContext
{
    public WorkshopContext(DbContextOptions<WorkshopContext> options)
        : base(options)
    {
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

}
