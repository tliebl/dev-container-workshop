using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkshopAPI.Database;
using WorkshopAPI.Database.Entities;

namespace WorkshopAPI.Database.Repositories;
public class WeatherForecastRepository : IWeatherForecastRepository
{
    private readonly WorkshopContext _context;

    public WeatherForecastRepository(WorkshopContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync()
    {
        return await _context.WeatherForecasts.ToListAsync();
    }
}