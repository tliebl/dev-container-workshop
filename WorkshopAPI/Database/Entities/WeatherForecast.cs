using System;
using System.ComponentModel.DataAnnotations;

namespace WorkshopAPI.Database.Entities;

    public class WeatherForecast
    {
        [Key]
        public int Id { get; set; } // Primary key
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

