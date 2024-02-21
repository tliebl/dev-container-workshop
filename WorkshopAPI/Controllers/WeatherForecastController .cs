using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAPI.Database.Repositories;
using WorkshopAPI.Database.Entities;

namespace WorkshopAPI.Controllers;

/// <summary>
/// Weather forecast controller
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly IWeatherForecastRepository _repository;

    public WeatherForecastController(IWeatherForecastRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await _repository.GetWeatherForecastsAsync();
    }

}
