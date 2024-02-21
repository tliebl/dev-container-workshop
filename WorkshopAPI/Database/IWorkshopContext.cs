using Microsoft.EntityFrameworkCore;
using WorkshopAPI.Database.Entities;

namespace WorkshopAPI.Database;

public interface IWorkshopContext
{
    DbSet<WeatherForecast> WeatherForecasts { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}