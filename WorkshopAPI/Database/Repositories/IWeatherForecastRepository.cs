using System.Collections.Generic;
using System.Threading.Tasks;
using WorkshopAPI.Database.Entities;

namespace WorkshopAPI.Database.Repositories;
public interface IWeatherForecastRepository
{
    Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync();
}
